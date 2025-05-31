using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        bool is_onoff = false;
        bool is_blinks = false;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void onoff_button_Click(object sender, EventArgs e)
        {
            if (is_onoff)
            {
                onoff_lamp.Visible = true;
                onoff_lamp.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            else
            {
                onoff_lamp.Visible = false;
            }
            is_onoff = !is_onoff;
        }

        private void blink_button_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int)interval.Value;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_blinks)
            {
                blink_lamp.Visible = true;
                blink_lamp.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            }
            else
            {
                blink_lamp.Visible = false;
            }

            is_blinks = !is_blinks;
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
