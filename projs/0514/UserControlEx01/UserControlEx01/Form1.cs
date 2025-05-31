using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlEx01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new UserControl1();
            uc.delete_button_event += Uc_delete_button_event; // user control의 delete_button_event 발생시 들어갈 함수를 추가

            flowLayoutPanel1.Controls.Add(uc);

            cnt_show_label.Text = "총" + flowLayoutPanel1.Controls.Count + "개";
        }


        private void Uc_delete_button_event(object sender, EventArgs e)
        {
            // 사용자 정의 컨트롤에서 delete button이 눌리면 실행됨
            if(sender is UserControl1)
            {
                flowLayoutPanel1.Controls.Remove((UserControl1)sender);
                cnt_show_label.Text = "총" + flowLayoutPanel1.Controls.Count + "개";
            }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cnt_show_label.Text = "총" + flowLayoutPanel1.Controls.Count + "개";
        }

        private void update_all_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if(control is UserControl1)
                {
                    ((UserControl1)control).make_guid();
                    ((UserControl1)control).make_random();
                    ((UserControl1)control).set_background();
                }
            }
        }
    }
}
