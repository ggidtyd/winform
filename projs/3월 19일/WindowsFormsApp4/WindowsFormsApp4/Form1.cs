using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_default_msg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메시지 박스");
        }

        private void btn_title_msg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("타이틀이 있는 메시지 박스", "타이틀");
        }

        private void btn_icon_msg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("아이콘이 있는 메시지 박스", "타이틀", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_yesno_msg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("종료할까요?", "경고", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 선택");
            }
            else
            {
                MessageBox.Show("No 선택");
            }
        }

        private void btn_yesnocancel_msg_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("종료할까요?", "경고", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 선택");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No 선택");
            }
            else
            {
                MessageBox.Show("Cancel 선택");
            }
        }
    }
}
