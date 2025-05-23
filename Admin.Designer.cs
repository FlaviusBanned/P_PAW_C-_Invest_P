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
            this.Stocks_button = new System.Windows.Forms.Button();
            this.Transactions_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.howToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Investors_button
            // 
            this.Investors_button.BackColor = System.Drawing.Color.Azure;
            this.Investors_button.Location = new System.Drawing.Point(250, 194);
            this.Investors_button.Name = "Investors_button";
            this.Investors_button.Size = new System.Drawing.Size(75, 23);
            this.Investors_button.TabIndex = 1;
            this.Investors_button.Text = "Investors";
            this.Investors_button.UseVisualStyleBackColor = false;
            this.Investors_button.Click += new System.EventHandler(this.Investors_button_Click);
            // 
            // Stocks_button
            // 
            this.Stocks_button.BackColor = System.Drawing.Color.Azure;
            this.Stocks_button.Location = new System.Drawing.Point(438, 194);
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
            this.Transactions_button.Location = new System.Drawing.Point(340, 194);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // howToToolStripMenuItem
            // 
            this.howToToolStripMenuItem.Name = "howToToolStripMenuItem";
            this.howToToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.howToToolStripMenuItem.Text = "Help";
            this.howToToolStripMenuItem.Click += new System.EventHandler(this.howToToolStripMenuItem_Click);
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
            this.Controls.Add(this.Investors_button);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "InvestMate";
            this.Load += new System.EventHandler(this.Admin_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Investors_button;
        private System.Windows.Forms.Button Stocks_button;
        private System.Windows.Forms.Button Transactions_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem howToToolStripMenuItem;
    }
}

