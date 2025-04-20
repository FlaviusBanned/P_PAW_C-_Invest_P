namespace ProiectPaw
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Investors_button = new System.Windows.Forms.Button();
            this.Portofolio_button = new System.Windows.Forms.Button();
            this.Stocks_button = new System.Windows.Forms.Button();
            this.Transactions_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Investors_button
            // 
            this.Investors_button.BackColor = System.Drawing.Color.Azure;
            this.Investors_button.Location = new System.Drawing.Point(212, 194);
            this.Investors_button.Name = "Investors_button";
            this.Investors_button.Size = new System.Drawing.Size(75, 23);
            this.Investors_button.TabIndex = 1;
            this.Investors_button.Text = "Investors";
            this.Investors_button.UseVisualStyleBackColor = false;
            this.Investors_button.Click += new System.EventHandler(this.Investors_button_Click);
            // 
            // Portofolio_button
            // 
            this.Portofolio_button.BackColor = System.Drawing.Color.Azure;
            this.Portofolio_button.Location = new System.Drawing.Point(293, 194);
            this.Portofolio_button.Name = "Portofolio_button";
            this.Portofolio_button.Size = new System.Drawing.Size(75, 23);
            this.Portofolio_button.TabIndex = 2;
            this.Portofolio_button.Text = "Portofolio";
            this.Portofolio_button.UseVisualStyleBackColor = false;
            // 
            // Stocks_button
            // 
            this.Stocks_button.BackColor = System.Drawing.Color.Azure;
            this.Stocks_button.Location = new System.Drawing.Point(374, 194);
            this.Stocks_button.Name = "Stocks_button";
            this.Stocks_button.Size = new System.Drawing.Size(75, 23);
            this.Stocks_button.TabIndex = 3;
            this.Stocks_button.Text = "Stocks";
            this.Stocks_button.UseVisualStyleBackColor = false;
            this.Stocks_button.Click += new System.EventHandler(this.Stocks_button_Click);
            // 
            // Transactions_button
            // 
            this.Transactions_button.BackColor = System.Drawing.Color.Azure;
            this.Transactions_button.Location = new System.Drawing.Point(455, 194);
            this.Transactions_button.Name = "Transactions_button";
            this.Transactions_button.Size = new System.Drawing.Size(83, 23);
            this.Transactions_button.TabIndex = 4;
            this.Transactions_button.Text = "Transactions";
            this.Transactions_button.UseVisualStyleBackColor = false;
            this.Transactions_button.Click += new System.EventHandler(this.Transactions_button_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "InvestMate Admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Transactions_button);
            this.Controls.Add(this.Stocks_button);
            this.Controls.Add(this.Portofolio_button);
            this.Controls.Add(this.Investors_button);
            this.Name = "Admin";
            this.Text = "InvestMate";
            this.Load += new System.EventHandler(this.Admin_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Investors_button;
        private System.Windows.Forms.Button Portofolio_button;
        private System.Windows.Forms.Button Stocks_button;
        private System.Windows.Forms.Button Transactions_button;
        private System.Windows.Forms.Label label2;
    }
}

