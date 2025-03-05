using System;
using System.Windows.Forms;

namespace ATMMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int amount;
            if (int.TryParse(txtAmount.Text, out amount) && amount > 0)
            {
                int fifty = amount / 50;
                amount %= 50;

                int twenty = amount / 20;
                amount %= 20;

                int ten = amount / 10;
                amount %= 10;

                int five = amount / 5;
                amount %= 5;

                lblFifty.Text = $"50 TL: {fifty}";
                lblTwenty.Text = $"20 TL: {twenty}";
                lblTen.Text = $"10 TL: {ten}";
                lblFive.Text = $"5 TL: {five}";

                lblRemaining.Text = $"Kalan: {amount} TL";
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
