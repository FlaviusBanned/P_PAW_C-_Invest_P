using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class InvestorsTab : Form
    {
        private List<Investor> investors = new List<Investor>();

        public InvestorsTab()
        {
            InitializeComponent();
         
        }

       

        private void RefreshGrid()
        {
            InvestorsData.DataSource = null;
            InvestorsData.DataSource = investors;
            InvestorsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InvestorsData.ReadOnly = true;
        }

        private void Add_Investor_button_Click(object sender, EventArgs e)
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(Name_textbox.Text) ||
                string.IsNullOrWhiteSpace(Surname_textbox.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumber_textbox.Text) ||
                string.IsNullOrWhiteSpace(InvestorEmail_textbox.Text))
            {
                MessageBox.Show("Please fill all the fields before adding the investor.");
                return;
            }

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

            investors.Add(newInvestor);

            // Refresh the grid to show the new investor
            RefreshGrid();

            // Select the first row by default after adding
            if (InvestorsData.Rows.Count > 0)
            {
                InvestorsData.Rows[0].Selected = true;
            }
        }

        private void Remove_Investor_button_Click(object sender, EventArgs e)
        {
            if (InvestorsData.SelectedRows.Count > 0)
            {
                int rowIndex = InvestorsData.SelectedRows[0].Index;

                if (rowIndex >= 0 && rowIndex < investors.Count)
                {
                    investors.RemoveAt(rowIndex);
                    RefreshGrid();
                    if (InvestorsData.Rows.Count > 0)
                    {int newRowIndex = rowIndex - 1;
                        if (newRowIndex < 0) newRowIndex = 0;
                        InvestorsData.Rows[newRowIndex].Selected = true;
                    }
                }
              
            }
            
        }

       
    }
}
