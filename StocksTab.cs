using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class StocksTab : Form
    {
        private BindingList<Stock> stockList = new BindingList<Stock>();
        private Timer updateTimer = new Timer();
        private Random random = new Random();
        private List<string> symbols = new List<string>
        {
            "AAPL", "MSFT", "GOOGL", "TSLA", "AMZN", "META", "NFLX", "NVDA", "INTC", "IBM",
            "ORCL", "SAP", "ADBE", "CRM", "CSCO", "QCOM", "TXN", "AMD", "BABA", "UBER",
            "LYFT", "PINS", "TWTR", "SNAP", "SHOP", "SQ", "ZM", "ROKU", "SPOT", "DOCU",
            "PLTR", "NIO", "XPEV", "LI", "JD", "BIDU", "TME", "VIPS", "WISH", "SOFI",
            "COIN", "PYPL", "AXP", "MA", "V", "DIS", "SONY", "EA", "ATVI", "TTWO"
        };

        public StocksTab()
        {
            InitializeComponent();
            this.Load += StocksTab_Load;
        }

        private void StocksTab_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var symbol in symbols)
                {
                    var price = (decimal)(random.NextDouble() * 1000 + 50); // Preț între 50 și 1050
                    stockList.Add(new Stock
                    {
                        CompanyName = symbol,
                        BuyPrice = price,
                        SellPrice = price + (decimal)(random.NextDouble() * 10) // Adaos vânzare
                    });
                }

                StocksTabel.DataSource = stockList;
                StocksTabel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Tabel investitori
                var investorsTable = LoadInvestors();
                if (investorsTable.Rows.Count > 0)
                {
                    GridStocksInvestitori.DataSource = investorsTable;
                    GridStocksInvestitori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Nu există investitori în baza de date.");
                }

                GridStocksInvestitori.ReadOnly = true;
                StocksTabel.ReadOnly = true;
                StocksTabel.ClearSelection();
                GridStocksInvestitori.ClearSelection();


                // Timer pentru actualizare prețuri
                updateTimer.Interval = random.Next(10000, 15000); // 10–15 secunde
                updateTimer.Tick += UpdateStockPrices;
                updateTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea datelor: {ex.Message}");
            }
        }

        private void UpdateStockPrices(object sender, EventArgs e)
        {
            foreach (var stock in stockList)
            {
                var change = (decimal)(random.NextDouble() * 20 - 10);
                stock.BuyPrice += change;
                if (stock.BuyPrice < 0)
                {
                    stock.BuyPrice = 100;
                }

                stock.SellPrice = stock.BuyPrice + (decimal)(random.NextDouble() * 5);
            }

            StocksTabel.Refresh();
            updateTimer.Interval = random.Next(10000, 15000);
        }

        private DataTable LoadInvestors()
        {
            var table = new DataTable();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var query = @"SELECT InvestorId, Name, Surname, AmountInvested FROM Investors";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea investitorilor: {ex.Message}");
            }

            return table;
        }        
        private void OpenTransactionForm(string actionType)
        {
            if (StocksTabel.SelectedRows.Count == 0 || GridStocksInvestitori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row from each table!");
                return;
            }

            
            var stock = StocksTabel.SelectedRows[0].DataBoundItem as Stock;
            var investor = GridStocksInvestitori.SelectedRows[0].DataBoundItem as DataRowView;
            int investorId = Convert.ToInt32(investor["InvestorId"]);
            string status = GetInvestorStatus(investorId);
            if (status.ToLower() != "active")
            {
                MessageBox.Show("Acest investitor este inactiv și nu poate efectua tranzacții.", "Investitor inactiv", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var transactionForm = new StockTransactionForm(stock, investor, actionType);
            transactionForm.ShowDialog();
            if (transactionForm.TransactionCompleted)
            {
                RefreshInvestorsGrid();
                GridStocksInvestitori.Refresh();
            }
        }

        
        private void BuyStockButton_Click(object sender, EventArgs e)
        {
            OpenTransactionForm("buy");
        }

        private void SellStockButton_Click(object sender, EventArgs e)
        {
            OpenTransactionForm("sell");
        }
        private void RefreshInvestorsGrid()
        {
            var updatedInvestors = LoadInvestors();
            GridStocksInvestitori.DataSource = updatedInvestors;
            GridStocksInvestitori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridStocksInvestitori.Refresh();
        }
        private string GetInvestorStatus(int investorId)
        {
            string status = "";
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT Status FROM Investors WHERE InvestorId = @InvestorId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvestorId", investorId);

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        status = result.ToString();
                    }
                }
            }

            return status;
        }

    }
}
