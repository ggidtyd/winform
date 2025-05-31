using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            UserControl1 user_control = new UserControl1();
            user_control.delete_event += User_control_delete_event;
            flowLayoutPanel1.Controls.Add(user_control);
            user_control_count();
        }

        private void User_control_delete_event(object sender, EventArgs e)
        {
            if (sender is UserControl)
            {
                DialogResult result = MessageBox.Show("정말 삭제 하겠습니까?", "경고", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    flowLayoutPanel1.Controls.Remove((UserControl1)sender);
                    user_control_count();
                }
            }
        }

        public void user_control_count()
        {
            cnt_label.Text = "총 " + flowLayoutPanel1.Controls.Count + "개";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            stop_all();
            flowLayoutPanel1.Controls.Clear();
            user_control_count();
        }

        private void update_all_button_Click(object sender, EventArgs e)
        {
            foreach (UserControl1 user_control in flowLayoutPanel1.Controls)
            {
                user_control.update();
            }
        }

        private void run_all_button_Click(object sender, EventArgs e)
        {
            run_all();
        }

        private void stop_all_button_Click(object sender, EventArgs e)
        {
            stop_all();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stop_all();
        }

        public void run_all()
        {
            foreach (UserControl1 user_control in flowLayoutPanel1.Controls)
            {
                if (user_control.IS_STOP)
                    user_control.run();
            }
        }

        public void stop_all()
        {
            foreach (UserControl1 user_control in flowLayoutPanel1.Controls)
            {
                if (user_control.IS_STOP == false)
                    user_control.stop_thread();
            }
        }
    }
}
