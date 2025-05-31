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

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void series_creation_button_Click(object sender, EventArgs e)
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

        private void random_value_add_button_Click(object sender, EventArgs e)
        {
            if(this.chart1.Series.Count > 0)
            {
                int rand_num = new Random().Next(0, 100);
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                DataPoint point = new DataPoint() { AxisLabel = now, YValues = new double[] { rand_num } };
                chart1.Series[0].Points.Add(point);
                if (chart1.Series[0].Points.Count > 10)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                }
            }
            else
            {

            }
        }
    }
}
