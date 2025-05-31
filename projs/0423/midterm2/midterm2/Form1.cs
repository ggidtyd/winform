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

namespace midterm2
{
    public partial class Form1 : Form
    {
        int chart1_point;
        int chart2_point;
        int chart3_point;
        int chart4_point;

        public Form1()
        {
            InitializeComponent();
            chart1_point = (int)chart1_point_num.Value;
            chart2_point = (int)chart2_point_num.Value;
            chart3_point = (int)chart3_point_num.Value;
            chart4_point = (int)chart4_point_num.Value;

            set_chart1();
            timer1.Interval = (int)chart1_v.Value;

            set_chart2();
            timer2.Interval = (int)chart2_v.Value;

            set_chart3();
            timer3.Interval = (int)chart3_v.Value;

            set_chart4();
            timer4.Interval = (int)chart4_v.Value;
        }

        private void chart1_start_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void chart2_start_button_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void chart3_start_button_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void chart4_start_button_Click(object sender, EventArgs e)
        {

            timer4.Start();
        }

        private void chart1_stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void chart2_stop_button_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void chart3_stop_button_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }

        private void chart4_stop_button_Click(object sender, EventArgs e)
        {
            timer4.Stop();
        }

        public void set_chart1()
        {
            chart1.Series.Clear();

            Series series1 = series_set();

            chart1.Series.Add(series1);
        }
        public void set_chart2()
        {
            chart2.Series.Clear();

            Series series1 = series_set();

            chart2.Series.Add(series1);
        }

        public void set_chart3()
        {
            chart3.Series.Clear();

            Series series1 = series_set();

            chart3.Series.Add(series1);
        }
        public void set_chart4()
        {
            chart4.Series.Clear();

            Series series1 = series_set();

            chart4.Series.Add(series1);
        }

        public Series series_set()
        {
            Series series1 = new Series();
            series1.Name = "Series 1";

            chart1.Titles.Clear();

            if (chart1_type.Text == "Column")
            {
                series1.ChartType = SeriesChartType.Column;
            }
            else if (chart1_type.Text == "Line")
            {
                series1.ChartType = SeriesChartType.Line;
            }
            else if (chart1_type.Text == "Point")
            {
                series1.ChartType = SeriesChartType.Point;
            }
            else if (chart1_type.Text == "Area")
            {
                series1.ChartType = SeriesChartType.Area;
            }

            series1.Color = Color.Red;

            return series1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd tt HH:mm:ss");

            if (chart1.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);

                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart1.Series[0].Points.Add(data_point);

                if (chart1.Series[0].Points.Count > chart1_point)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart1 Series가 존재하지 않습니다.");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd tt HH:mm:ss");

            if (chart2.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);

                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart2.Series[0].Points.Add(data_point);

                if (chart2.Series[0].Points.Count > chart2_point)
                {
                    chart2.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart2 Series가 존재하지 않습니다.");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd tt HH:mm:ss");

            if (chart3.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);

                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart3.Series[0].Points.Add(data_point);

                if (chart3.Series[0].Points.Count > chart3_point)
                {
                    chart3.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart3 Series가 존재하지 않습니다.");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd tt HH:mm:ss");

            if (chart4.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);

                DataPoint data_point = new DataPoint() { AxisLabel = time, YValues = new double[] { rand_num } };
                chart4.Series[0].Points.Add(data_point);

                if (chart4.Series[0].Points.Count > chart4_point)
                {
                    chart4.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Chart3 Series가 존재하지 않습니다.");
            }
        }

        private void chart1_v_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)chart1_v.Value;
        }

        private void chart1_point_num_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)chart1_point_num.Value;
            int cur = chart1.Series[0].Points.Count;
            if (value < cur)
            {
                for(int i = 0; i < cur - value; i++)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }
            }
            chart1_point = value;
        }

        private void chart2_v_ValueChanged(object sender, EventArgs e)
        {
            timer2.Interval = (int)chart2_v.Value;
        }

        private void chart2_point_num_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)chart2_point_num.Value;
            int cur = chart2.Series[0].Points.Count;
            if (value < cur)
            {
                for (int i = 0; i < cur - value; i++)
                {
                    chart2.Series[0].Points.RemoveAt(0);
                }
            }
            chart2_point = value;
        }

        private void chart3_v_ValueChanged(object sender, EventArgs e)
        {
            timer3.Interval = (int)chart3_v.Value;
        }

        private void chart3_point_num_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)chart3_point_num.Value;
            int cur = chart3.Series[0].Points.Count;
            if (value < cur)
            {
                for (int i = 0; i < cur - value; i++)
                {
                    chart3.Series[0].Points.RemoveAt(0);
                }
            }
            chart3_point = value;
        }

        private void chart4_v_ValueChanged(object sender, EventArgs e)
        {
            timer4.Interval = (int)chart4_v.Value;
        }

        private void chart4_point_num_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)chart4_point_num.Value;
            int cur = chart4.Series[0].Points.Count;
            if (value < cur)
            {
                for (int i = 0; i < cur - value; i++)
                {
                    chart4.Series[0].Points.RemoveAt(0);
                }
            }
            chart4_point = value;
        }

        private void chart1_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart1_type.Text == "Column")
            {
                chart1.Series[0].ChartType = SeriesChartType.Column;
            }
            else if (chart1_type.Text == "Line")
            {
                chart1.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (chart1_type.Text == "Point")
            {
                chart1.Series[0].ChartType = SeriesChartType.Point;
            }
            else if (chart1_type.Text == "Area")
            {
                chart1.Series[0].ChartType = SeriesChartType.Area;
            }
        }

        private void chart2_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart2_type.Text == "Column")
            {
                chart2.Series[0].ChartType = SeriesChartType.Column;
            }
            else if (chart2_type.Text == "Line")
            {
                chart2.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (chart2_type.Text == "Point")
            {
                chart2.Series[0].ChartType = SeriesChartType.Point;
            }
            else if (chart2_type.Text == "Area")
            {
                chart2.Series[0].ChartType = SeriesChartType.Area;
            }
        }

        private void chart3_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart3_type.Text == "Column")
            {
                chart3.Series[0].ChartType = SeriesChartType.Column;
            }
            else if (chart3_type.Text == "Line")
            {
                chart3.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (chart3_type.Text == "Point")
            {
                chart3.Series[0].ChartType = SeriesChartType.Point;
            }
            else if (chart3_type.Text == "Area")
            {
                chart3.Series[0].ChartType = SeriesChartType.Area;
            }
        }

        private void chart4_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chart4_type.Text == "Column")
            {
                chart4.Series[0].ChartType = SeriesChartType.Column;
            }
            else if (chart4_type.Text == "Line")
            {
                chart4.Series[0].ChartType = SeriesChartType.Line;
            }
            else if (chart4_type.Text == "Point")
            {
                chart4.Series[0].ChartType = SeriesChartType.Point;
            }
            else if (chart4_type.Text == "Area")
            {
                chart4.Series[0].ChartType = SeriesChartType.Area;
            }
        }
    }
}
