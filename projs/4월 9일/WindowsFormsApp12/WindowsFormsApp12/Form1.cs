using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void trackbar_ValueChanged(object sender, EventArgs e)
        {
            int red = trackbar_red.Value;
            int green = trackbar_green.Value;
            int blue = trackbar_blue.Value;
            int alpha = trackbar_alpha.Value;

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int red = rand.Next(0, 255);
            int green = rand.Next(0, 255);
            int blue = rand.Next(0, 255);
            int alpha = rand.Next(0, 255);

            trackbar_red.Value = red;
            trackbar_green.Value = green;
            trackbar_blue.Value = blue;
            trackbar_alpha.Value = alpha;

            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);
        }

        private void auto_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            auto_button.Enabled = false;
        }

        private void manual_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            auto_button.Enabled = true;
        }
    }
}
