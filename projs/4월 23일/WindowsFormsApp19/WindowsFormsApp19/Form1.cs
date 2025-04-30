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

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            set_chart();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chart1.Series.Count > 0)
            {
                int rand_num = new Random().Next(1, 100);
                string date = DateTime.Now.ToString("HH:mm:ss");
                DataPoint data_point = new DataPoint() { AxisLabel = date, YValues = new double[] { rand_num } };
                chart1.Series[0].Points.Add(data_point);

                if (chart1.Series[0].Points.Count > 50)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Chart Series가 존재하지 않습니다.");
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void set_chart()
        {
            this.chart1.Series.Clear();

            Series series = new Series();
            series.Name = "데이터 1";

            chart1.Titles.Clear();
            Title title = new Title();
            title.Text = "차트 제목";
            chart1.Titles.Add(title);

            series.ChartType = SeriesChartType.Column;

            chart1.Series.Add(series);
        }
    }
}
