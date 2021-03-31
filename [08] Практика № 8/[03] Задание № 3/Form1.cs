using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _03__Задание___3
{
    public partial class Form1 : Form
    {
        public double XMin;
        public double XMax;
        public double Step;
        public double[] X;
        public double[] Y;

        Chart chart;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Задание № 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
            X = new double[count];
            Y = new double[count];
            for (int i = 0; i < count; i++)
            {
                X[i] = XMin + Step * i;
                Y[i] = ((Math.Sqrt(2 + (3 * Math.Pow(Math.Cos(2 * X[i]), 2)) + 2)) - 1) / ((Math.Pow(2, 1 + Math.Log(X[i]))) - Math.Abs(1 - Math.Sin(Math.Sqrt(2 + X[i]))));
            }
        }
        public void CreateChart()
        {
            chart = new Chart();
            chart.Parent = this;
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);

            ChartArea area = new ChartArea();
            area.Name = "Graph";
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            area.AxisX.MajorGrid.Interval = Step;
            chart.ChartAreas.Add(area);

            Series series = new Series();
            series.ChartArea = "Graph";
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = 3;
            series.LegendText = "График №3";
            chart.Series.Add(series);

            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XMin = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error with XMin", "Error");
                return;
            }
            try
            {
                XMax = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error with XMax", "Error");
                return;
            }
            Step = ((Math.Abs(XMax) + Math.Abs(XMin)) * 3) / 5;
            textBox3.Text = Step.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XMin = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error with XMin", "Error");
                return;
            }
            try
            {
                XMax = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error with XMax", "Error");
                return;
            }
            try
            {
                Step = Convert.ToDouble(textBox3.Text);
                if (Step <= ((Math.Abs(XMax) + Math.Abs(XMin)) / 2))
                {
                    MessageBox.Show("Error with Step, Error Value", "Error");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error with Step", "Error");
                return;
            }

            panel1.Visible = false;
            try
            {
                CreateChart();
                CalcFunction();
            }
            catch
            {
                MessageBox.Show("Такие значения нельзя использовать", "Error");
            }
            chart.Series[0].Points.DataBindXY(X, Y);
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Refresh();
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
