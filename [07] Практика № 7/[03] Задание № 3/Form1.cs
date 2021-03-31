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
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            button2.Enabled = false;
        }

        public static int N = new int();
        public static int[,] Array;

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Значение 'N' - пустое", "Error");
                return;
            }
            try
            {
                N = Convert.ToInt32(textBox2.Text);
                if (N <= 0 && N >= 16)
                {
                    MessageBox.Show("Пожалуйста вводите цифры в диапозоне от 1 до 15", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста вводите только цифры", "Error");
                return;
            }

            Random random = new Random();

            Array = new int[N, N];

            dataGridView1.RowCount = N;
            dataGridView1.ColumnCount = N;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Array[i, j] = random.Next(-99, 100);
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(Array[i, j]);
                }
            }

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Max = int.MinValue; 
            int Min = int.MaxValue; 
            int PosMaxX = new int(), PosMaxY = new int();
            int PosMinX = new int(), PosMinY = new int();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Max < Array[i, j])
                    {
                        Max = Array[i, j];
                        PosMaxX = i;
                        PosMaxY = j;
                    }
                    if (Min > Array[i, j])
                    {
                        Min = Array[i, j];
                        PosMinX = i;
                        PosMinY = j;
                    }
                }
            }

            dataGridView1.Rows[PosMaxX].Cells[PosMaxY].Value = Min;
            dataGridView1.Rows[PosMinX].Cells[PosMinY].Value = Max;

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
