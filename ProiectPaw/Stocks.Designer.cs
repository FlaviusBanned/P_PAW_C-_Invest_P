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
            ((System.ComponentModel.ISupportInitialize)(this.StocksTabel)).BeginInit();
            this.SuspendLayout();
            // 
            // StocksTabel
            // 
            this.StocksTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksTabel.Location = new System.Drawing.Point(12, 65);
            this.StocksTabel.Name = "StocksTabel";
            this.StocksTabel.Size = new System.Drawing.Size(330, 305);
            this.StocksTabel.TabIndex = 0;
            this.StocksTabel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StocksTabel_CellContentClick);
            // 
            // BuyStockButton
            // 
            this.BuyStockButton.BackColor = System.Drawing.Color.LimeGreen;
            this.BuyStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuyStockButton.Location = new System.Drawing.Point(88, 396);
            this.BuyStockButton.Name = "BuyStockButton";
            this.BuyStockButton.Size = new System.Drawing.Size(75, 23);
            this.BuyStockButton.TabIndex = 1;
            this.BuyStockButton.Text = "Buy";
            this.BuyStockButton.UseVisualStyleBackColor = false;
            // 
            // SellStockButton
            // 
            this.SellStockButton.BackColor = System.Drawing.Color.Crimson;
            this.SellStockButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SellStockButton.Location = new System.Drawing.Point(169, 396);
            this.SellStockButton.Name = "SellStockButton";
            this.SellStockButton.Size = new System.Drawing.Size(75, 23);
            this.SellStockButton.TabIndex = 2;
            this.SellStockButton.Text = "Sell";
            this.SellStockButton.UseVisualStyleBackColor = false;
            // 
            // StocksTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SellStockButton);
            this.Controls.Add(this.BuyStockButton);
            this.Controls.Add(this.StocksTabel);
            this.Name = "StocksTab";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.StocksTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StocksTabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StocksTabel;
        private System.Windows.Forms.Button BuyStockButton;
        private System.Windows.Forms.Button SellStockButton;
    }
}