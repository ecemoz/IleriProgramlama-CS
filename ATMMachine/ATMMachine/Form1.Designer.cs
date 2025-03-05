namespace ATMMachine
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFifty = new System.Windows.Forms.Label();
            this.lblTwenty = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblFive = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(87, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Para Miktarı (TL):";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(130, 27);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 1;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(250, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblFifty
            this.lblFifty.AutoSize = true;
            this.lblFifty.Location = new System.Drawing.Point(30, 80);
            this.lblFifty.Name = "lblFifty";
            this.lblFifty.Size = new System.Drawing.Size(44, 13);
            this.lblFifty.TabIndex = 3;

            // lblTwenty
            this.lblTwenty.AutoSize = true;
            this.lblTwenty.Location = new System.Drawing.Point(30, 110);
            this.lblTwenty.Name = "lblTwenty";
            this.lblTwenty.Size = new System.Drawing.Size(44, 13);
            this.lblTwenty.TabIndex = 4;

            // lblTen
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(30, 140);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(38, 13);
            this.lblTen.TabIndex = 5;

            // lblFive
            this.lblFive.AutoSize = true;
            this.lblFive.Location = new System.Drawing.Point(30, 170);
            this.lblFive.Name = "lblFive";
            this.lblFive.Size = new System.Drawing.Size(38, 13);
            this.lblFive.TabIndex = 6;

            // lblRemaining
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(30, 200);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(44, 13);
            this.lblRemaining.TabIndex = 7;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblFive);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblTwenty);
            this.Controls.Add(this.lblFifty);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "ATM Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFifty;
        private System.Windows.Forms.Label lblTwenty;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblFive;
        private System.Windows.Forms.Label lblRemaining;
    }
}
