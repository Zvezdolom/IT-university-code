using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16__Задание___16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double Factorial(double x)
        {
            if (x == 0)
                return 1;
            return x * Factorial(x - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Multiplication = 1;
            int SelectedItem = new int();
            double Part = new double();
            double Iteration = 1;

            double Range = Convert.ToDouble(textBox1.Text);

            if (radioButton1.Checked == radioButton2.Checked)
            {
                textBox2.Text = "Пожалуйста выберите действие" + Environment.NewLine;
                return;
            }

            textBox2.Text = "Результаты работы программы ст. Калинина В.Н. " + Environment.NewLine;
            textBox2.Text += "При Range = " + textBox1.Text + Environment.NewLine;

            if (radioButton1.Checked)
                SelectedItem = 1;
            if (radioButton2.Checked)
                SelectedItem = 2;

            switch (SelectedItem)
            {
                case 1:
                    textBox2.Text += "Для данного выражения можно посчитать только произведения ряда P" + Environment.NewLine;
                    break;
                case 2:
                    for (; Iteration <= Range; Iteration++)
                    {
                        Part = Math.Sqrt(Factorial(Iteration) + 10 * Iteration) / (3 * Iteration - 2);
                        Multiplication *= Part;
                    }
                    textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(Multiplication) + Environment.NewLine;
                    break;
            }
        }
    }
}
