using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        int timeLeft = 30; // 30으로 초기화

        public Form1()
        {
            InitializeComponent();
            this.time_label.Text = timeLeft + " Second"; // label에 시간을 보여준다.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0) // 시간이 0보다 크다면
            {
                timeLeft--;
                this.time_label.Text = timeLeft + " Second";
            }
            else
            {
                timer1.Stop();
                this.time_label.Text = timeLeft + " Second";

                timeLeft = 30; // 30으로 다시 초기화
            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
