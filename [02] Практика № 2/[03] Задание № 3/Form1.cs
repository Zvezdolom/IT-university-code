using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03__Задание___3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Задание №3 Калинин В. Н.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения ......";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
            double y = ((Math.Sqrt(2+(3*Math.Pow(Math.Cos(2*x),2))+2))-1)/((Math.Pow(2,1+Math.Log(x)))-Math.Abs(1-Math.Sin(Math.Sqrt(2+x))));
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }
    }
}
