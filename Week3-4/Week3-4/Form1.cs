using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(a == b && b == c)
            {
                MessageBox.Show("Congratulations! You won!");
            }
            else if (a == b || b == c || a == c)
            {
                MessageBox.Show("You are very close! Keep Going!!");
            }
            else
            {
                MessageBox.Show("Sorry! You lost!");
            }
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            a= (int)rnd.Next(1,10); 
            b= (int)rnd.Next(1,10);
            c= (int)rnd.Next(1,10);
            
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
        }
    }
}
