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
            this.BackColor = Color.AntiqueWhite;
            label1.Text = "Начало работы";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
