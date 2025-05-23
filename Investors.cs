using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class InvestorsTab : Form
    {
        public InvestorsTab()
        {
            InitializeComponent();
            this.Load += InvestorsTab_Load;
        }

        private void InvestorsTab_Load(object sender, EventArgs e)
        {
            LoadInvestorsFromDatabase();
            InvestorsData.CellValueChanged += InvestorsData_CellValueChanged;
            InvestorsData.UserDeletingRow += InvestorsData_UserDeletingRow;
        }

        private void Add_Investor_button_Click(object sender, EventArgs e)
        {
            var newInvestor = new Investor
            {
                Name = Name_textbox.Text.Trim(),
                Surname = Surname_textbox.Text.Trim(),
                PhoneNumber = PhoneNumber_textbox.Text.Trim(),
                Email = InvestorEmail_textbox.Text.Trim(),
                AmountInvested = numericUpDown1.Value,
                DateJoined = DateInvestorJoined.Value,
                Status = "Non-Active"
            };

            InsertInvestorToDatabase(newInvestor);
            LoadInvestorsFromDatabase();
            if (InvestorsData.Rows.Count > 0)
            {
                InvestorsData.Rows[0].Selected = true;
            }
        }

        private void Remove_Investor_button_Click(object sender, EventArgs e)
        {
            if (InvestorsData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = InvestorsData.SelectedRows[0];
                var investorId = Convert.ToInt32(selectedRow.Cells["InvestorId"].Value);
                DeleteInvestorFromDatabase(investorId);
                LoadInvestorsFromDatabase();
            }
        }

        private void RefreshDataGridView_Click(object sender, EventArgs e)
        {
            LoadInvestorsFromDatabase();
        }

        private void MoneyInvestLabel_Click(object sender, EventArgs e)
        {
             
        }

        private void LoadInvestorsFromDatabase()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM [dbo].[Investors]";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataTable.AcceptChanges();
                InvestorsData.DataSource = dataTable;

                
                InvestorsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                
                InvestorsData.Columns["InvestorId"].Width = 60;
                InvestorsData.Columns["Name"].Width = 100;
                InvestorsData.Columns["Surname"].Width = 100;
                InvestorsData.Columns["PhoneNumber"].Width = 90;
                InvestorsData.Columns["Email"].Width = 150;
                InvestorsData.Columns["AmountInvested"].Width = 120;
                InvestorsData.Columns["DateJoined"].Width = 130;
                InvestorsData.Columns["Status"].Width = 80;

                InvestorsData.ReadOnly = false;
            }
        }


        private void InsertInvestorToDatabase(Investor newInvestor)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO [dbo].[Investors] (Name, Surname, PhoneNumber, Email, AmountInvested, DateJoined, Status) " +
                               "VALUES (@Name, @Surname, @PhoneNumber, @Email, @AmountInvested, @DateJoined, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", newInvestor.Name);
                    cmd.Parameters.AddWithValue("@Surname", newInvestor.Surname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", newInvestor.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", newInvestor.Email);
                    cmd.Parameters.AddWithValue("@AmountInvested", newInvestor.AmountInvested);
                    cmd.Parameters.AddWithValue("@DateJoined", newInvestor.DateJoined);
                    cmd.Parameters.AddWithValue("@Status", newInvestor.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void DeleteInvestorFromDatabase(int id)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM [dbo].[Investors] WHERE InvestorId = @InvestorId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvestorId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InvestorsData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var updatedRow = InvestorsData.Rows[e.RowIndex];
                int investorId = Convert.ToInt32(updatedRow.Cells["InvestorId"].Value);
                string updatedName = updatedRow.Cells["Name"].Value.ToString();
                string updatedSurname = updatedRow.Cells["Surname"].Value.ToString();
                string updatedPhoneNumber = updatedRow.Cells["PhoneNumber"].Value.ToString();
                string updatedEmail = updatedRow.Cells["Email"].Value.ToString();
                decimal updatedAmountInvested = Convert.ToDecimal(updatedRow.Cells["AmountInvested"].Value);
                DateTime updatedDateJoined = Convert.ToDateTime(updatedRow.Cells["DateJoined"].Value);
                string updatedStatus = updatedRow.Cells["Status"].Value.ToString();

                UpdateInvestorInDatabase(investorId, updatedName, updatedSurname, updatedPhoneNumber, updatedEmail, updatedAmountInvested, updatedDateJoined, updatedStatus);
            }
        }

        private void UpdateInvestorInDatabase(int investorId, string name, string surname, string phoneNumber, string email, decimal amountInvested, DateTime dateJoined, string status)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE [dbo].[Investors] SET Name = @Name, Surname = @Surname, PhoneNumber = @PhoneNumber, Email = @Email, AmountInvested = @AmountInvested, DateJoined = @DateJoined, Status = @Status WHERE InvestorId = @InvestorId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@InvestorId", investorId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@AmountInvested", amountInvested);
                    cmd.Parameters.AddWithValue("@DateJoined", dateJoined);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadInvestorsFromDatabase();
        }

        private void InvestorsData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int investorId = Convert.ToInt32(e.Row.Cells["InvestorId"].Value);
            DeleteInvestorFromDatabase(investorId);
        }

        private void InvestorsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
