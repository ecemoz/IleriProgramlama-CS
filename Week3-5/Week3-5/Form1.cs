using System;
using System.Windows.Forms;

namespace Week3_5
{
    public partial class Form1 : Form
    {
        private int hareketMiktari = 10; 
        private int altSinir = 350; 
        private int ustSinir = 10; 

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Top += hareketMiktari;

            if (panel1.Top >= altSinir || panel1.Top <= ustSinir)
            {
                hareketMiktari *= -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
    }
}
