using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class StocksTab : Form
    {
        private BindingList<Stock> stockList = new BindingList<Stock>();

        public StocksTab()
        {
            InitializeComponent();
            this.Load += StocksTab_Load;
        }

        private void StocksTab_Load(object sender, EventArgs e)
        {
            // Add sample stock data
            stockList.Add(new Stock { CompanyName = "Apple", BuyPrice = 150, SellPrice = 175 });
            stockList.Add(new Stock { CompanyName = "Google", BuyPrice = 1200, SellPrice = 1350 });
            stockList.Add(new Stock { CompanyName = "Nvidia", BuyPrice = 300, SellPrice = 350 });

            // Bind list to DataGridView
            StocksTabel.DataSource = stockList;


            StocksTabel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StocksTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
