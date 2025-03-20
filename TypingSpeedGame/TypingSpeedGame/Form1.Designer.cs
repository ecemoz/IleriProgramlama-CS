namespace TypingSpeedGame
{
    partial class GameForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(55, 185);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(50, 16);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "WORD";
            this.lblWord.Click += new System.EventHandler(this.lblWord_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(158, 182);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 22);
            this.txtInput.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(55, 251);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(56, 16);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(174, 251);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 16);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Time Left: 30";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(523, 365);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblWord);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer gameTimer;
    }
}

