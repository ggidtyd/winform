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

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart_create_button_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            Series chart_series1 = chart1.Series.Add("데이터 1");
            Series chart_series2 = chart1.Series.Add("데이터 2");
            Series chart_series3 = chart1.Series.Add("데이터 3");

            chart1.Titles.Clear();
            Title title = new Title();
            title.Text = "차트 제목";
            title.ForeColor = Color.White;
            title.BackColor = Color.Green;
            title.Font = new Font("맑은고딕", 20, FontStyle.Bold);
            chart1.Titles.Add(title);

            // Chart Type
            chart_series1.ChartType = SeriesChartType.Line;
            chart_series2.ChartType = SeriesChartType.Column;
            chart_series3.ChartType = SeriesChartType.Point;
            // 다음 페이지

            // 차트 색상 설정
            chart_series1.Color = Color.LightGreen;
            chart_series2.Color = Color.Red;
            chart_series3.Color = Color.Red;

            // 차트 굵기 설정
            chart_series1.BorderWidth = 20;
            chart_series2.BorderWidth = 2;
            chart_series3.BorderWidth = 5;

            // Chart_Series1, Chart_Series3 Data
            for (double i = 0; i < 2 * Math.PI; i += 0.5)
            {
                chart_series1.Points.AddXY(i, Math.Sin(i));
                chart_series3.Points.AddXY(i, Math.Sin(i));
            }

            // Chart_Series2 Data
            for (double i = 0; i < 2; i += 0.1)
            {
                chart_series2.Points.AddXY(i, i);
            }
        }
    }
}
