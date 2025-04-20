namespace ProiectPaw
{
    partial class InvestorsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestorsTab));
            this.InvestorsData = new System.Windows.Forms.DataGridView();
            this.Label_Investors = new System.Windows.Forms.Label();
            this.Add_Investor_button = new System.Windows.Forms.Button();
            this.Remove_Investor_button = new System.Windows.Forms.Button();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.Surname_textbox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_textbox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MoneyInvestLabel = new System.Windows.Forms.Label();
            this.DateInvestorJoined = new System.Windows.Forms.DateTimePicker();
            this.InvestorEmail_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InvestorsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // InvestorsData
            // 
            this.InvestorsData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.InvestorsData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InvestorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvestorsData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvestorsData.Location = new System.Drawing.Point(12, 97);
            this.InvestorsData.Name = "InvestorsData";
            this.InvestorsData.Size = new System.Drawing.Size(718, 341);
            this.InvestorsData.TabIndex = 0;
            // 
            // Label_Investors
            // 
            this.Label_Investors.AutoSize = true;
            this.Label_Investors.BackColor = System.Drawing.Color.Transparent;
            this.Label_Investors.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Investors.Location = new System.Drawing.Point(147, 53);
            this.Label_Investors.Name = "Label_Investors";
            this.Label_Investors.Size = new System.Drawing.Size(226, 19);
            this.Label_Investors.TabIndex = 1;
            this.Label_Investors.Text = "List of Active/Non-Active Investors";
            // 
            // Add_Investor_button
            // 
            this.Add_Investor_button.BackColor = System.Drawing.Color.Green;
            this.Add_Investor_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Investor_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Investor_button.Location = new System.Drawing.Point(806, 97);
            this.Add_Investor_button.Name = "Add_Investor_button";
            this.Add_Investor_button.Size = new System.Drawing.Size(75, 23);
            this.Add_Investor_button.TabIndex = 2;
            this.Add_Investor_button.Text = "Add";
            this.Add_Investor_button.UseVisualStyleBackColor = false;
            this.Add_Investor_button.Click += new System.EventHandler(this.Add_Investor_button_Click);
            // 
            // Remove_Investor_button
            // 
            this.Remove_Investor_button.BackColor = System.Drawing.Color.Crimson;
            this.Remove_Investor_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Investor_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove_Investor_button.Location = new System.Drawing.Point(887, 97);
            this.Remove_Investor_button.Name = "Remove_Investor_button";
            this.Remove_Investor_button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Investor_button.TabIndex = 3;
            this.Remove_Investor_button.Text = "Remove";
            this.Remove_Investor_button.UseVisualStyleBackColor = false;
            this.Remove_Investor_button.Click += new System.EventHandler(this.Remove_Investor_button_Click);
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(806, 145);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(200, 20);
            this.Name_textbox.TabIndex = 5;
            this.Name_textbox.Text = "Name...";
            // 
            // Surname_textbox
            // 
            this.Surname_textbox.Location = new System.Drawing.Point(806, 171);
            this.Surname_textbox.Name = "Surname_textbox";
            this.Surname_textbox.Size = new System.Drawing.Size(200, 20);
            this.Surname_textbox.TabIndex = 6;
            this.Surname_textbox.Text = "Surname...";
            // 
            // PhoneNumber_textbox
            // 
            this.PhoneNumber_textbox.Location = new System.Drawing.Point(806, 197);
            this.PhoneNumber_textbox.Name = "PhoneNumber_textbox";
            this.PhoneNumber_textbox.Size = new System.Drawing.Size(200, 20);
            this.PhoneNumber_textbox.TabIndex = 7;
            this.PhoneNumber_textbox.Text = "Phone Number ...";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(806, 279);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(141, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // MoneyInvestLabel
            // 
            this.MoneyInvestLabel.AutoSize = true;
            this.MoneyInvestLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyInvestLabel.Location = new System.Drawing.Point(803, 263);
            this.MoneyInvestLabel.Name = "MoneyInvestLabel";
            this.MoneyInvestLabel.Size = new System.Drawing.Size(106, 13);
            this.MoneyInvestLabel.TabIndex = 10;
            this.MoneyInvestLabel.Text = "Money for Investing :";
            // 
            // DateInvestorJoined
            // 
            this.DateInvestorJoined.Location = new System.Drawing.Point(806, 319);
            this.DateInvestorJoined.Name = "DateInvestorJoined";
            this.DateInvestorJoined.Size = new System.Drawing.Size(200, 20);
            this.DateInvestorJoined.TabIndex = 11;
            // 
            // InvestorEmail_textbox
            // 
            this.InvestorEmail_textbox.Location = new System.Drawing.Point(806, 223);
            this.InvestorEmail_textbox.Name = "InvestorEmail_textbox";
            this.InvestorEmail_textbox.Size = new System.Drawing.Size(200, 20);
            this.InvestorEmail_textbox.TabIndex = 12;
            this.InvestorEmail_textbox.Text = "Email ...";
            // 
            // InvestorsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.InvestorEmail_textbox);
            this.Controls.Add(this.DateInvestorJoined);
            this.Controls.Add(this.MoneyInvestLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.PhoneNumber_textbox);
            this.Controls.Add(this.Surname_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Remove_Investor_button);
            this.Controls.Add(this.Add_Investor_button);
            this.Controls.Add(this.Label_Investors);
            this.Controls.Add(this.InvestorsData);
            this.Name = "InvestorsTab";
            this.Text = "Investors";
          
            ((System.ComponentModel.ISupportInitialize)(this.InvestorsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InvestorsData;
        private System.Windows.Forms.Label Label_Investors;
        private System.Windows.Forms.Button Add_Investor_button;
        private System.Windows.Forms.Button Remove_Investor_button;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox Surname_textbox;
        private System.Windows.Forms.TextBox PhoneNumber_textbox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label MoneyInvestLabel;
        private System.Windows.Forms.DateTimePicker DateInvestorJoined;
        private System.Windows.Forms.TextBox InvestorEmail_textbox;
    }
}
