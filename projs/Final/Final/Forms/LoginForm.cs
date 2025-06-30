using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Final.DB;
using Final.Models;

namespace Final.Forms
{
    public partial class LoginForm : Form
    {
        public User loginUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int count = 0;
            string id = txtUserId.Text.Trim();
            string pw = txtPassword.Text.Trim();
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM users WHERE user_id = @id AND user_pw = @pw";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        loginUser = DatabaseManager.getUser(id, conn);
                        Hide();
                        new MainForm(loginUser).ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패. 아이디와 비밀번호를 확인하세요.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Close();
            }
        }
    }
}
