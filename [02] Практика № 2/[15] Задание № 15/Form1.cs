using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15__Задание___15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Задание №15 Калинин В. Н.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения ......";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
            double y = (5+3*Math.Log10(Math.Sqrt(1+2*x)))/(2*Math.Pow(Math.E,1+0.5*x*x)-Math.Abs(1-2*x)+3);
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }
    }
}
