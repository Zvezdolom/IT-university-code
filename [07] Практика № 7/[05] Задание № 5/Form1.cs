using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05__Задание___5
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
            int MinSum = int.MaxValue;
            int MaxSum = int.MinValue;
            int MinRow = new int(), MaxRow = new int();

            int Sum = new int();

            for (int i = 0; i < N; i++)
            {
                Sum = 0;
                for (int j = 0; j < N; j++)
                {
                    Sum += Array[i, j];
                }
                if (MinSum > Sum)
                {
                    MinSum = Sum;
                    MinRow = i;
                }
                if (MaxSum < Sum)
                {
                    MaxSum = Sum;
                    MaxRow = i;
                }
            }

            label2.Text = $"Сумма элементов макс. в\nстроке {MaxRow}\nСумма элементов мин. в\nстроке {MinRow}";

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
