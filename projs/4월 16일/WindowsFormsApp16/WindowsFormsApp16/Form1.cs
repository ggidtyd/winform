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

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void draw_button_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("차트 제목");

            chart1.Series[0].Points.Clear();

            chart1.Series[0].Points.AddXY(1, 10);
            chart1.Series[0].Points.AddXY(2, 20);
            chart1.Series[0].Points.AddXY(3, 30);
            chart1.Series[0].Points.AddXY(4, 40);
            chart1.Series[0].Points.AddXY(5, 50);
            chart1.Series[0].Points.AddXY(10, 60);
            chart1.Series[0].Name = "1번 시리즈";
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Color = Color.Black;

            chart1.Series[1].Points.Clear();

            chart1.Series[1].Points.Add(2);
            chart1.Series[1].Points.Add(23);
            chart1.Series[1].Points.Add(13);
            chart1.Series[1].Points.Add(18);
            chart1.Series[1].Points.Add(24);
            chart1.Series[1].Name = "2번 시리즈";
            chart1.Series[1].ChartType = SeriesChartType.Line;

        }
    }
}
