using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int time_left = 0;
        int rand_num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            time_left = 120;
            rand_num = random.Next(0, 100);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_left--;

            if (time_left > 0)
            {
                if(numericUpDown1.Value == rand_num)
                {
                    // 맞췄을 경우 코드
                    up_down_label.Text = "맞췄습니다";
                    timer1.Stop();
                }
                else
                {
                    // UP  DOWN을 보여준다.
                    if (numericUpDown1.Value < rand_num)
                    {
                        up_down_label.Text = "Up";
                    }
                    else if (numericUpDown1.Value > rand_num)
                    {
                        up_down_label.Text = "Down";
                    }
                }
            }
            else
            {
                // 시간을 다 쓰고 못맞춤
                up_down_label.Text = "패배";
                timer1.Stop();
            }
        }
    }
}
