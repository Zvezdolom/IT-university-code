using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10__Задание___10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            textBox1.Text = "Готов к работе";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "*****";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "+++++";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "00000";
        }
    }
}
