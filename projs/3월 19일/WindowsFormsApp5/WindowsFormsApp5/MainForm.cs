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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 로드할때 로그인창을 다이얼로그로 보여줌
            LoginForm login_form = new LoginForm();
            DialogResult result = login_form.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("로그인 완료");
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
