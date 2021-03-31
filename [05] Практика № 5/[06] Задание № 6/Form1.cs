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

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select the line", "Error");
                return;
            }
            string str = listBox1.Items[index].ToString();

            string s = "";
            for (int i = str.Length; i > 0; i--)
            {
                s += str[i - 1];
            }
            if (s == str)
            {
                label1.Text = "Результат: палиндромом";
            }
            if (s != str)
            {
                label1.Text = "Результат: Не палиндромом";
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Textbox is empty", "Error");
                return;
            }
            listBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please select the line", "Error");
                return;
            }
            listBox1.Items.RemoveAt(index);
        }
    }
}
