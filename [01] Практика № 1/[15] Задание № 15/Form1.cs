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

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Location = new Point(295, 12);
            button3.Location = new Point(12, 149);
            button4.Location = new Point(295, 149);

            button2.Size = new Size(50,50);
            button3.Size = new Size(60,60);
            button4.Size = new Size(70,70);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(87, 22);
            button3.Location = new Point(87, 128);
            button4.Location = new Point(255, 128);

            button1.Size = new Size(80, 100);
            button3.Size = new Size(75, 75);
            button4.Size = new Size(100, 80);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(91, 12);
            button2.Location = new Point(300, 5);
            button4.Location = new Point(283, 117);

            button1.Size = new Size(100, 40);
            button2.Size = new Size(65, 120);
            button4.Size = new Size(60, 75);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(1, 2);
            button2.Location = new Point(116, 76);
            button3.Location = new Point(1, 160);

            button1.Size = new Size(30, 100);
            button2.Size = new Size(90, 60);
            button3.Size = new Size(55, 20);
        }
    }
}
