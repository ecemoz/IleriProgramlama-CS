using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = -1;
            panel1.BackColor = Color.Pink;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = 1;
            panel1.BackColor = Color.DeepPink;
        }
    }
}
