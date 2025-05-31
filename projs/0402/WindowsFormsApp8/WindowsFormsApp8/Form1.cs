using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void random_button_Click(object sender, EventArgs e)
        {
            rand_num();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rand_num();
        }

        private void rand_num()
        {
            label_10.Text = rand.Next(1, 10).ToString();
            label_100.Text = rand.Next(1, 100).ToString();
            label_1000.Text = rand.Next(1, 1000).ToString();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
