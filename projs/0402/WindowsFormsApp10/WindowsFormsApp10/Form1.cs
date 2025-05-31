using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int add1;
        int add2;
        int add_answer;

        int min1;
        int min2;
        int min_answer;

        int mul1;
        int mul2;
        int mul_answer;

        int div1;
        int div2;
        int div_answer;

        int time_left;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            time_left = 60;
            time_left_label.Text = time_left.ToString();
            timer1.Start();

            add1 = random.Next(1, 100);
            add2 = random.Next(1, 100);
            min1 = random.Next(1, 100);
            min2 = random.Next(1, 100);
            mul1 = random.Next(1, 100);
            mul2 = random.Next(1, 100);
            div1 = random.Next(1, 100);
            div2 = random.Next(1, 100);

            plus_label1.Text = add1.ToString();
            plus_label2.Text = add2.ToString();
            minus_label1.Text= min1.ToString();
            minus_label2.Text = min2.ToString();
            mul_label1.Text = mul1.ToString();
            mul_label2.Text = mul2.ToString();
            div_label1.Text = div1.ToString();
            div_label2.Text = div2.ToString();

            add_answer = add1 + add2;
            min_answer = min1 - min2;
            mul_answer = mul1 * mul2;
            div_answer = div1 / div2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_left--;
            time_left_label.Text = time_left.ToString();
            if (time_left <= 0)
            {
                timer1.Stop();
                start_button.Enabled = true;
                MessageBox.Show("시간 초과, 실패");
                return;
            }

            if(plus_input.Value == add_answer && minus_input.Value == min_answer
                && mul_input.Value == mul_answer && div_input.Value == div_answer)
            {
                timer1.Stop();
                start_button.Enabled = true;
                MessageBox.Show("모두 맞췄습니다.");
                return;
            }
        }
    }
}
