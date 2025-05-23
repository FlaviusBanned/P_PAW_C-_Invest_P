namespace ProiectPaw
{
    partial class StocksTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StocksTab));
            this.StocksTabel = new System.Windows.Forms.DataGridView();
            this.BuyStockButton = new System.Windows.Forms.Button();
            this.SellStockButton = new System.Windows.Forms.Button();
            this.Stoc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GridStocksInvestitori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StocksTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStocksInvestitori)).BeginInit();
            this.SuspendLayout();
            // 
            // StocksTabel
            // 
            this.StocksTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksTabel.Location = new System.Drawing.Point(12, 100);
            this.StocksTabel.Name = "StocksTabel";
            this.StocksTabel.Size = new System.Drawing.Size(624, 270);
            this.StocksTabel.TabIndex = 0;
            // 
            // BuyStockButton
            // 
            this.BuyStockButton.BackColor = System.Drawing.Color.LimeGreen;
            this.BuyStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyStockButton.Location = new System.Drawing.Point(561, 396);
            this.BuyStockButton.Name = "BuyStockButton";
            this.BuyStockButton.Size = new System.Drawing.Size(75, 23);
            this.BuyStockButton.TabIndex = 1;
            this.BuyStockButton.Text = "Buy";
            this.BuyStockButton.UseVisualStyleBackColor = false;
            this.BuyStockButton.Click += new System.EventHandler(this.BuyStockButton_Click);
            // 
            // SellStockButton
            // 
            this.SellStockButton.BackColor = System.Drawing.Color.Crimson;
            this.SellStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellStockButton.Location = new System.Drawing.Point(663, 396);
            this.SellStockButton.Name = "SellStockButton";
            this.SellStockButton.Size = new System.Drawing.Size(75, 23);
            this.SellStockButton.TabIndex = 2;
            this.SellStockButton.Text = "Sell";
            this.SellStockButton.UseVisualStyleBackColor = false;
            this.SellStockButton.Click += new System.EventHandler(this.SellStockButton_Click);
            // 
            // Stoc
            // 
            this.Stoc.AutoSize = true;
            this.Stoc.BackColor = System.Drawing.Color.Transparent;
            this.Stoc.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stoc.Location = new System.Drawing.Point(583, 33);
            this.Stoc.Name = "Stoc";
            this.Stoc.Size = new System.Drawing.Size(155, 28);
            this.Stoc.TabIndex = 3;
            this.Stoc.Text = "Stocks Market";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.OldLace;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 73);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // GridStocksInvestitori
            // 
            this.GridStocksInvestitori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStocksInvestitori.Location = new System.Drawing.Point(663, 100);
            this.GridStocksInvestitori.Name = "GridStocksInvestitori";
            this.GridStocksInvestitori.Size = new System.Drawing.Size(624, 270);
            this.GridStocksInvestitori.TabIndex = 5;
            // 
            // StocksTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1335, 450);
            this.Controls.Add(this.GridStocksInvestitori);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Stoc);
            this.Controls.Add(this.SellStockButton);
            this.Controls.Add(this.BuyStockButton);
            this.Controls.Add(this.StocksTabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StocksTab";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.StocksTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StocksTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridStocksInvestitori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StocksTabel;
        private System.Windows.Forms.Button BuyStockButton;
        private System.Windows.Forms.Button SellStockButton;
        private System.Windows.Forms.Label Stoc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView GridStocksInvestitori;
    }
}