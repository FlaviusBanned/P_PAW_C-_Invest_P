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
    public partial class HowTo : Form
    {
        public HowTo()
        {
            InitializeComponent();
            richTextBoxHelp.Font = new Font("Segoe UI Emoji", 10);
            this.Load += HowTo_Load;  // aici legi evenimentul Load corect
        }

        private void HowTo_Load(object sender, EventArgs e)
        {
            richTextBoxHelp.Font = new Font("Segoe UI Emoji", 10);

            richTextBoxHelp.Text =
                "📘 **InvestMate Application User Guide**\n\n" +

                "🔧 **Technologies Used:**\n" +
                "🔹 Windows Forms for the graphical interface\n" +
                "🔹 SQL Server + T-SQL for data management\n" +
                "🔹 iTextSharp for generating PDF reports\n\n" +

                "👤 **Investors:**\n" +
                "   ➕ Add new investors\n" +
                "   📝 Edit existing investor details\n" +
                "   ❌ Delete investors from the system\n\n" +

                "📈 **Stocks:**\n" +
                "   🔁 Update stock prices at regular intervals\n" +
                "   💼 Based on selected investors and stocks, you can initiate transactions\n\n" +

                "🧾 **Transactions:**\n" +
                "   📋 View the complete transaction history\n" +
                "   🕒 Each transaction includes details such as stock symbol, quantity, price, type (buy/sell), and date\n\n" +

                "📄 **Report Generation:**\n" +
                "   🖨️ Generate a PDF report with all recorded transactions\n" +
                "   📂 The PDF file is saved locally and can be reviewed later\n\n" +

                "ℹ️ Please ensure all data is correct before generating the report!\n";
        }


        private void richTextBoxHelp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
