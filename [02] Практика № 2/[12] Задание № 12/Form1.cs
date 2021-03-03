using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12__Задание___12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Задание №12 Калинин В. Н.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения ......";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
            double y = (Math.Pow(Math.E,x-Math.Sqrt(x)))/(Math.Log10((x+5)/(x+1))-2*((x*x*x+x)/(1+Math.Abs(Math.Sin(x)))));
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }
    }
}
