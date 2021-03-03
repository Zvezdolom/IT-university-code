using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05__Задание___5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SelectedItem = new int();
            double Answer = new int();
            double X = new int();

            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);

            textBox4.Text = "Результаты работы программы ст. Калинина В.Н. " + Environment.NewLine;

            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;

            if (radioButton1.Checked)
                SelectedItem = 1;
            if (radioButton2.Checked)
                SelectedItem = 2;
            if (radioButton3.Checked)
                SelectedItem = 3;

            switch (SelectedItem)
            {
                case 1:
                    X = Math.Sinh(x);
                    break;
                case 2:
                    X = Math.Cosh(x);
                    break;
                case 3:
                    X = Math.Exp(x);
                    break;
                default:
                    textBox4.Text += "Решение не найдено" + Environment.NewLine;
                    return;
            }

            if (x >= 7)
                Answer = 4;
            if ((-2 < x) && (x < 7))
                Answer = X - 2;
            if (x <= -2)
                Answer = Math.Sqrt(x + 2);

            textBox4.Text += "y = " + Answer.ToString() + Environment.NewLine;
        }
    }
}
