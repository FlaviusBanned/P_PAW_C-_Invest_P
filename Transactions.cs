using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProiectPaw
{
    public partial class TransactionsTab : Form
    {
        private DataTable transactionTable; // pentru filtrare/sortare

        public TransactionsTab()
        {
            InitializeComponent();
        }

        private void TransactionsTab_Load(object sender, EventArgs e)
        {
            // populăm comboBox-urile
            comboBox1.Items.AddRange(new string[] { "Price", "Quantity", "TransactionDate" });
            comboBox2.Items.AddRange(new string[] { "ASC", "DESC" });
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            LoadTransactionData();
        }

        private void LoadTransactionData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MaterialeSezon4\\C#\\ProiectPaw\\InvestMateBD.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT InvestorName, StockSymbol, Quantity, Price, TransactionType, TransactionDate FROM Transactions";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    transactionTable = new DataTable();
                    adapter.Fill(transactionTable);
                    TransactionsData.DataSource = transactionTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea tranzacțiilor: " + ex.Message);
            }
        }

        // Aplică filtrul și sortarea
        private void ApplyFilterAndSort()
        {
            if (transactionTable == null) return;

            string filter = "";
            string sort = "";

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                filter = $"StockSymbol LIKE '%{textBox2.Text.Replace("'", "''")}%'"; // protecție SQL injection
            }

            string sortColumn = comboBox1.Text;
            string sortOrder = comboBox2.Text;
            if (!string.IsNullOrWhiteSpace(sortColumn) && !string.IsNullOrWhiteSpace(sortOrder))
            {
                sort = $"{sortColumn} {sortOrder}";
            }

            transactionTable.DefaultView.RowFilter = filter;
            transactionTable.DefaultView.Sort = sort;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveDialog.Title = "Save Transaction Report";
            saveDialog.FileName = "TransactionReport.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;

                try
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
                    pdfDoc.Open();

                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    Paragraph title = new Paragraph("Transaction Report", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 20f;
                    pdfDoc.Add(title);

                    PdfPTable table = new PdfPTable(6);
                    table.WidthPercentage = 100;

                    string[] headers = { "Investor", "Stock", "Quantity", "Price", "Type", "Date" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                        cell.BackgroundColor = new BaseColor(230, 230, 250);
                        table.AddCell(cell);
                    }

                    // Exportăm exact ce se vede (filtrat și sortat)
                    DataView view = transactionTable.DefaultView;
                    foreach (DataRowView rowView in view)
                    {
                        DataRow row = rowView.Row;
                        for (int i = 0; i < 6; i++)
                        {
                            table.AddCell(row[i]?.ToString() ?? "");
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();

                    MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Neutilizate, dar lăsate pentru completitudine
        private void label1_Click(object sender, EventArgs e) { }
        private void StocksTabel_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void TransactionsData_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
