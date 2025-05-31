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

namespace midterm
{
    public partial class Form1 : Form
    {
        int point;

        public Form1()
        {
            InitializeComponent();
            point = (int)point_numericUpDown.Value;
            timer1.Interval = (int)v_numericUpDown.Value;

            set_chart();
        }

        public void set_chart()
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart4.Series.Clear();

            Series series1 = new Series();
            series1.Name = "Series 1";
            Series series2 = new Series();
            series1.Name = "Series 2";
            Series series3 = new Series();
            series1.Name = "Series 3";
            Series series4 = new Series();
            series1.Name = "Series 4";

            chart1.Titles.Clear();
            chart2.Titles.Clear();
            chart3.Titles.Clear();
            chart4.Titles.Clear();

            Title title1 = new Title();
            title1.Text = "데이터 1";
            Title title2 = new Title();
            title2.Text = "데이터 2";
            Title title3 = new Title();
            title3.Text = "데이터 3";
            Title title4 = new Title();
            title4.Text = "데이터 4";

            chart1.Titles.Add(title1);
            chart2.Titles.Add(title2);
            chart3.Titles.Add(title3);
            chart4.Titles.Add(title4);

            series1.ChartType = SeriesChartType.Column;
            series2.ChartType = SeriesChartType.Line;
            series3.ChartType = SeriesChartType.Point;
            series4.ChartType = SeriesChartType.Area;

            series1.Color = Color.Red;
            series2.Color = Color.Green;
            series3.Color = Color.Black;
            series4.Color = Color.Blue;

            chart1.Series.Add(series1);
            chart2.Series.Add(series2);
            chart3.Series.Add(series3);
            chart4.Series.Add(series4);
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd tt HH:mm:ss");

            if (chart1.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);
                
                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart1.Series[0].Points.Add(data_point);

                if (chart1.Series[0].Points.Count > point)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart1 Series가 존재하지 않습니다.");
            }

            if (chart2.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);
                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart2.Series[0].Points.Add(data_point);

                if (chart2.Series[0].Points.Count > point)
                {
                    chart2.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart2 Series가 존재하지 않습니다.");
            }

            if (chart3.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);
                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart3.Series[0].Points.Add(data_point);

                if (chart3.Series[0].Points.Count > point)
                {
                    chart3.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart3 Series가 존재하지 않습니다.");
            }

            if (chart4.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);
                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart4.Series[0].Points.Add(data_point);

                if (chart4.Series[0].Points.Count > point)
                {
                    chart4.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart4 Series가 존재하지 않습니다.");
            }
        }

        private void v_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)v_numericUpDown.Value;
        }

        private void point_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)point_numericUpDown.Value;
            int cur = chart1.Series[0].Points.Count;

            if (value < cur)
            {
                for (int i = 0; i < cur - value; i++)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart2.Series[0].Points.RemoveAt(0);
                    chart3.Series[0].Points.RemoveAt(0);
                    chart4.Series[0].Points.RemoveAt(0);
                }
            }
            point = value;
        }
    }
}
