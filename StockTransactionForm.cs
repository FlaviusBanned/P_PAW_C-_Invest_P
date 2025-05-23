using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class StockTransactionForm : Form
    {
        public string ActionType { get; private set; }
        public int Quantity => (int)QuantityInput.Value;
        public decimal Price { get; private set; }
        public decimal Total => Quantity * Price;
        public bool TransactionCompleted { get; private set; } = false;

        private Stock stock;
        private DataRowView investor;


        public StockTransactionForm(Stock stock, DataRowView investor, string actionType)
        {
            InitializeComponent();

            this.ActionType = actionType;
            this.Price = (actionType == "buy") ? stock.BuyPrice : stock.SellPrice; 
            this.stock = stock;
            this.investor = investor;

            QuantityInput.ValueChanged += QuantityInput_ValueChanged;
            UpdateTotal();
        }


        private void QuantityInput_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            InputTotal.Text = $"{Quantity * Price:0.00} RON";

        }


        private void AcceptTransactionButton_Click(object sender, EventArgs e)
        {
            if (Quantity <= 0)
            {
                MessageBox.Show("Cantitatea trebuie să fie mai mare decât 0.");
                return;
            }

            string investorName = investor["Name"].ToString();
            string stockSymbol = stock.CompanyName;
            int investorId = Convert.ToInt32(investor["InvestorId"]);
            decimal stockPrice = stock.BuyPrice;

            if (ActionType == "buy")
            {
                ExecuteBuyTransaction(investorId, investorName, investor["Surname"].ToString(), Quantity, stockPrice);
            }
            else if (ActionType == "sell")
            {
                ExecuteSellTransaction(investorId, investorName, investor["Surname"].ToString(), Quantity, stockPrice);
            }

            LogTransaction(investorId, investorName, stockSymbol, Quantity, stockPrice, ActionType);
            TransactionCompleted = true;
            this.Close();
        }

        private void ExecuteBuyTransaction(int investorId, string name, string surname, int quantity, decimal stockPrice)
        {
            decimal totalPrice = quantity * stockPrice;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificăm dacă există deja portofoliu
                    string checkPortfolioQuery = @"SELECT COUNT(*) FROM Portfolios WHERE InvestorId = @InvestorId";
                    using (SqlCommand checkCmd = new SqlCommand(checkPortfolioQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@InvestorId", investorId);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            // Update
                            string updatePortfolioQuery = @"UPDATE Portfolios 
                        SET TransactionsBalance = TransactionsBalance + @TotalPrice 
                        WHERE InvestorId = @InvestorId";
                            using (SqlCommand cmd = new SqlCommand(updatePortfolioQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@InvestorId", investorId);
                                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert
                            string insertPortfolioQuery = @"INSERT INTO Portfolios (InvestorId, Name, Surname, TransactionsBalance) 
                        VALUES (@InvestorId, @Name, @Surname, @TotalPrice)";
                            using (SqlCommand cmd = new SqlCommand(insertPortfolioQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@InvestorId", investorId);
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@Surname", surname);
                                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Scade banii investiți
                    string updateInvestorsQuery = @"UPDATE Investors 
                SET AmountInvested = AmountInvested - @TotalPrice 
                WHERE InvestorId = @InvestorId";
                    using (SqlCommand cmd = new SqlCommand(updateInvestorsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvestorId", investorId);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la executarea tranzacției: {ex.Message}");
            }
        }

        private void ExecuteSellTransaction(int investorId, string name, string surname, int quantity, decimal stockPrice)
        {
            decimal totalPrice = quantity * stockPrice;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificare dacă portofoliul are suficient sold
                    string checkBalanceQuery = @"SELECT TransactionsBalance FROM Portfolios WHERE InvestorId = @InvestorId";
                    using (SqlCommand checkCmd = new SqlCommand(checkBalanceQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@InvestorId", investorId);
                        object result = checkCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Portofoliul nu există.");
                            return;
                        }

                        decimal currentBalance = (decimal)result;
                        if (currentBalance < totalPrice)
                        {
                            MessageBox.Show("Sold insuficient pentru vânzare.");
                            return;
                        }
                    }

                    // Scade din portofoliu
                    string updatePortfolioQuery = @"UPDATE Portfolios 
                SET TransactionsBalance = TransactionsBalance - @TotalPrice 
                WHERE InvestorId = @InvestorId";
                    using (SqlCommand cmd = new SqlCommand(updatePortfolioQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvestorId", investorId);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.ExecuteNonQuery();
                    }

                    // Adaugă în AmountInvested
                    string updateInvestorsQuery = @"UPDATE Investors 
                SET AmountInvested = AmountInvested + @TotalPrice 
                WHERE InvestorId = @InvestorId";
                    using (SqlCommand cmd = new SqlCommand(updateInvestorsQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvestorId", investorId);
                        cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tranzacția de vânzare a fost înregistrată cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la executarea tranzacției: {ex.Message}");
            }
        }

        private void LogTransaction(int investorId, string investorName, string stockSymbol, int quantity, decimal price, string transactionType)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertTransactionQuery = @"INSERT INTO Transactions (InvestorName, StockSymbol, Quantity, Price, TransactionType, TransactionDate)
                                              VALUES (@InvestorName, @StockSymbol, @Quantity, @Price, @TransactionType, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvestorName", investorName);
                        cmd.Parameters.AddWithValue("@StockSymbol", stockSymbol);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@TransactionType", transactionType);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tranzacția a fost înregistrată în log!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la logarea tranzacției: {ex.Message}");
            }
        }

       

        private void StockTransactionForm_Load(object sender, EventArgs e) { }
        private void LabelQuantity_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void InputTotal_TextChanged(object sender, EventArgs e) { }
    }
}
