using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.Load += Admin_load;
        }


        private void Admin_load(object sender, EventArgs e)
        {
          
            this.BeginInvoke((Action)(() =>
            {
                this.ActiveControl = null;
            }));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Investors_button_Click(object sender, EventArgs e)
        {
            InvestorsTab investorForm= new InvestorsTab();
            investorForm.Show();
        }

        private void Transactions_button_Click(object sender, EventArgs e)
        {
            TransactionsTab transactionLog= new TransactionsTab();
            transactionLog.Show();
        }

        private void Stocks_button_Click(object sender, EventArgs e)
        {
            StocksTab stocksForm = new StocksTab();
            stocksForm.Show();

        }

        private void howToToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            HowTo howto = new HowTo();
            howto.Show();
        }

    }
}
