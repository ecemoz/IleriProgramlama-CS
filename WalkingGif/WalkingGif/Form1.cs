using System;
using System.Drawing;
using System.Windows.Forms;

namespace WalkingGif
{
    public partial class Form1 : Form
    {
        private Panel[] platforms; 
        private int platformSpeed = 5; 
        private int platformCount = 3; 
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializePlatforms();
            StartTimer();
        }

        private void InitializePlatforms()
        {
           
            platforms = new Panel[] { panel1, panel2, panel3 };
        }

        private void StartTimer()
        {
            timer = new Timer
            {
                Interval = 50 
            };
            timer.Tick += MovePlatforms;
            timer.Start();
        }

        private void MovePlatforms(object sender, EventArgs e)
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                
                platforms[i].Left -= platformSpeed;

                
                if (platforms[i].Right < 0)
                {
                    platforms[i].Left = this.ClientSize.Width;
                }
            }
        }
    }
}
