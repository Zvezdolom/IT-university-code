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
            button2.Enabled = false;
        }

        public static int[] Array;

        private void button1_Click(object sender, EventArgs e)
        {
            int Elements = new int();
            int Min = new int();
            int Max = new int();

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Значение 'Количество элементов' - пустое", "Error");
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Значение 'min порог для рандома' - пустое", "Error");
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Значение 'max порог для рандома' - пустое", "Error");
                return;
            }
            try
            {
                Elements = Convert.ToInt32(textBox2.Text);
                if (Elements <= 0 && Elements >= 26)
                {
                    MessageBox.Show("Пожалуйста вводите цифры в диапозоне от 1 до 25", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста вводите только цифры", "Error");
                return;
            }
            try
            {
                Min = Convert.ToInt32(textBox3.Text);
                if (Min <= -101 && Min >= 101)
                {
                    MessageBox.Show("Пожалуйста вводите цифры в диапозоне от -100 до 100", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста вводите только цифры", "Error");
                return;
            }
            try
            {
                Max = Convert.ToInt32(textBox4.Text);
                if (Max <= -101 && Max >= 101)
                {
                    MessageBox.Show("Пожалуйста вводите цифры в диапозоне от -100 до 100", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста вводите только цифры", "Error");
                return;
            }
            if (Min >= Max)
            {
                MessageBox.Show("Минимальный элемент не может быть больше или равняться максимальному", "Error");
                return;
            }

            textBox1.Clear();

            Array = new int[Elements];

            Random random = new Random();

            for (int i = 0; i < Elements; i++)
            {
                Array[i] = random.Next(Min, Max + 1);
                textBox1.Text += Array[i] + Environment.NewLine;
            }

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > 0 && Array[i] < 7)
                {
                    Counter++;
                }
            }

            label5.Text = "количество положительных элементов \nмассива, не превышающих числа 7: " + Counter.ToString();

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
