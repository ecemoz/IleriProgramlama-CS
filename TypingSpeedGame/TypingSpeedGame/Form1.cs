using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TypingSpeedGame
{
    public partial class GameForm : Form
    {
        private List<string> words = new List<string> { "computer", "keyboard", "monitor", "developer", "programming", "software", "hardware", "internet", "security", "network" };
        private string currentWord;
        private int score = 0;
        private int timeLeft = 30; // 30 saniyelik oyun süresi
        private Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
            GenerateRandomWord();
            this.KeyPreview = true;
            txtInput.KeyDown += new KeyEventHandler(TxtInput_KeyDown);
            gameTimer.Interval = 1000; // Her saniye çalışacak
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && timeLeft > 0)
            {
                if (txtInput.Text.Trim().ToLower() == currentWord.ToLower())
                {
                    score += 10; // Doğru cevap için 10 puan
                    lblScore.Text = "Score: " + score;
                    GenerateRandomWord();
                }
                else
                {
                    score -= 5; // Yanlış cevap için 5 puan düş
                    lblScore.Text = "Score: " + score;
                }
                txtInput.Clear();
            }
        }

        private void GenerateRandomWord()
        {
            currentWord = words[random.Next(words.Count)];
            lblWord.Text = currentWord;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Time Left: " + timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                txtInput.Enabled = false;
                MessageBox.Show("Game Over! Your Score: " + score);
            }
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }
    }
}
