namespace ProiectPaw
{
    partial class StockTransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTransactionForm));
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.NumericUpDown();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.InputTotal = new System.Windows.Forms.TextBox();
            this.AcceptTransactionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.LabelQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantity.Location = new System.Drawing.Point(54, 54);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(76, 21);
            this.LabelQuantity.TabIndex = 0;
            this.LabelQuantity.Text = "Quantity";
            this.LabelQuantity.Click += new System.EventHandler(this.LabelQuantity_Click);
            // 
            // QuantityInput
            // 
            this.QuantityInput.Location = new System.Drawing.Point(171, 55);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(120, 20);
            this.QuantityInput.TabIndex = 1;
            this.QuantityInput.ValueChanged += new System.EventHandler(this.QuantityInput_ValueChanged);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.BackColor = System.Drawing.Color.Transparent;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(82, 141);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(48, 21);
            this.LabelTotal.TabIndex = 2;
            this.LabelTotal.Text = "Total";
            this.LabelTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputTotal
            // 
            this.InputTotal.Location = new System.Drawing.Point(171, 144);
            this.InputTotal.Name = "InputTotal";
            this.InputTotal.Size = new System.Drawing.Size(100, 20);
            this.InputTotal.TabIndex = 3;
            this.InputTotal.TextChanged += new System.EventHandler(this.InputTotal_TextChanged);
            // 
            // AcceptTransactionButton
            // 
            this.AcceptTransactionButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AcceptTransactionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AcceptTransactionButton.Location = new System.Drawing.Point(127, 236);
            this.AcceptTransactionButton.Name = "AcceptTransactionButton";
            this.AcceptTransactionButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptTransactionButton.TabIndex = 4;
            this.AcceptTransactionButton.Text = "Accept";
            this.AcceptTransactionButton.UseVisualStyleBackColor = false;
            this.AcceptTransactionButton.Click += new System.EventHandler(this.AcceptTransactionButton_Click);
            // 
            // StockTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(368, 292);
            this.Controls.Add(this.AcceptTransactionButton);
            this.Controls.Add(this.InputTotal);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.QuantityInput);
            this.Controls.Add(this.LabelQuantity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockTransactionForm";
            this.Text = "StockTransactionForm";
            this.Load += new System.EventHandler(this.StockTransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.NumericUpDown QuantityInput;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.TextBox InputTotal;
        private System.Windows.Forms.Button AcceptTransactionButton;
    }
}