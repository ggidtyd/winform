using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("정말 종료?", "확인", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //this.Close();
                Application.Exit();
            }
        }

        public void login()
        {
            // 1. 화면에서 ID와 PW를 가져온다
            string user_id = userid_input.Text;
            string user_pw = pw_input.Text;

            // 2. 아이디 비밀번호를 입력했는지 체크하여 입력하게끔 알려준다
            if (user_id == string.Empty)
            {
                MessageBox.Show("User ID를 입력하세요");
                userid_input.Focus();
                return;
            }
            if (user_pw == string.Empty)
            {
                MessageBox.Show("Password를 입력하세요");
                pw_input.Focus();
                return;
            }
            // 3. 아이디와 비밀번호를 내가 정한 아이디와 비밀번호가 맞는지 체크한다
            // 4. 맞다면 로그인 메시지를 보여준다
            if (user_id == "admin" && user_pw == "1234")
            {
                MessageBox.Show("반갑습니다 관리자님");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            // 5. 틀렸다면 아이디 비밀번호 입력칸을 지우고 다시 로그인 하라고 메시지를 보여준다
            else
            {
                MessageBox.Show("아이디와 비밀번호가 일치하지 않습니다");
                userid_input.Text = "";
                pw_input.Text = "";
                userid_input.Focus();
                return;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login();
        }

        private void pw_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
