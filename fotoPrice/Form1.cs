using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotoPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0, sum;
            int n;
            if (radioButton1.Checked)
                price = 8.50;
            if (radioButton1.Checked)
                price = 10;
            if (radioButton1.Checked)
                price = 15.50;
            n = Convert.ToInt32(textBox1.Text);
            sum = n * price;

            label2.Text = "Цена:" + price.ToString("c") +
                "\nКоличество:" + n.ToString() + "шт.\n" +
                "Сумма заказа: " + sum.ToString("c");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if(Char.IsControl(e.KeyChar))
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
                return;
            }
            e.Handled = true; //check
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else button1.Enabled = true;
            label2.Text = "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            textBox1.Focus();
        }
    }
}
