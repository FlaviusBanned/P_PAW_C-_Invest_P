namespace ProiectPaw
{
    partial class HowTo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowTo));
            this.richTextBoxHelp = new System.Windows.Forms.RichTextBox();
            this.LabelHowToTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxHelp
            // 
            this.richTextBoxHelp.Location = new System.Drawing.Point(12, 148);
            this.richTextBoxHelp.Name = "richTextBoxHelp";
            this.richTextBoxHelp.Size = new System.Drawing.Size(776, 290);
            this.richTextBoxHelp.TabIndex = 0;
            this.richTextBoxHelp.Text = "";
            // 
            // LabelHowToTitle
            // 
            this.LabelHowToTitle.AutoSize = true;
            this.LabelHowToTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelHowToTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHowToTitle.Location = new System.Drawing.Point(328, 85);
            this.LabelHowToTitle.Name = "LabelHowToTitle";
            this.LabelHowToTitle.Size = new System.Drawing.Size(141, 24);
            this.LabelHowToTitle.TabIndex = 1;
            this.LabelHowToTitle.Text = "  == How To ==";
            this.LabelHowToTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "InvestMate App\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelHowToTitle);
            this.Controls.Add(this.richTextBoxHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HowTo";
            this.Text = "HowTo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHelp;
        private System.Windows.Forms.Label LabelHowToTitle;
        private System.Windows.Forms.Label label1;
    }
}