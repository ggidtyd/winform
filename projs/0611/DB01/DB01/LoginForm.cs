using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB01
{
    public partial class LoginForm : Form
    {
        public Users login_user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            MySqlUtil myu = new MySqlUtil();

            string uid = this.id_input_text_box.Text;
            string pwd = this.pw_input_text_box.Text;

            int result = myu.login(uid, pwd);
            if (result == 0)
            {
                MessageBox.Show("로그인 실패");
            }
            else
            {
                myu.update_user_login_date(uid); // 로그인 시간 갱신

                login_user = myu.get_user(uid); // 로그인 사용자 정보 받기

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
