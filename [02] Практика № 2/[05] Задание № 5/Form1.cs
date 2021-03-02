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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Задание №5 Калинин В. Н.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения ......";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
            double y = (x + Math.Sin(0.5 * x) + Math.Sqrt(Math.Log(x, 10)) / (2 + 3 * Math.Cos(x)) + (Math.Pow(Math.E, 2 * x - 0.5)) / (2 + x));
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }
    }
}
