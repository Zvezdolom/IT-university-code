using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08__Задание___8
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
            double Sum = 0;
            int SelectedItem = new int();
            double Part = new double();
            double Iteration = 2;

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
                    Part = (Iteration - 1) / (2 * Factorial(Iteration) - 2);
                    while (Part >= Range)
                    {
                        Part = (Iteration - 1) / (2 * Factorial(Iteration) - 2);
                        Sum += Part;
                        Iteration++;
                    }
                    textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(Sum) + Environment.NewLine;
                    break;
                case 2:
                    textBox2.Text += "Для данного выражения можно посчитать только сумму ряда S" + Environment.NewLine;
                    break;
            }
        }
    }
}
