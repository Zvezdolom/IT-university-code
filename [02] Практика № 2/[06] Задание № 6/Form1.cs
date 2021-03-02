using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06__Задание___6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Практическая работа №2 Задание №6 Калинин В. Н.";
            textBox2.Text += Environment.NewLine + "Рассчитать значение выражения ......";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            textBox2.Text += Environment.NewLine + "При x = " + x.ToString();
            double y = ((Math.Sqrt(Math.Pow(x,3))-Math.Log(x))/(Math.Cos(2*Math.Pow(x,2))+Math.Abs(x+3)))+((3*Math.Pow(x-2,2))/(Math.Log(x)+2));
            textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
        }
    }
}
