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
    public partial class Form1 : Form
    {
        public Users login_user;

        public Form1()
        {
            InitializeComponent();
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm();
            DialogResult result = login_form.ShowDialog();

            if (result == DialogResult.OK)
            {
                login_user = login_form.login_user;
                MessageBox.Show("안녕하세요 " + login_user.user_name + "님");
            }
            else
            {
                this.Close();
            }
            init_user_grid();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("종료할까요", "경고", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void init_user_grid()
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MySqlUtil mysql = new MySqlUtil();
            List<Users> userlist = mysql.get_users();  // 사용자 조회 호출 
            this.dataGridView1.DataSource = userlist;  // DataGridView에 바인딩.

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 200;
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            AddUsers add_users = new AddUsers();
            DialogResult result = add_users.ShowDialog();

            if(result == DialogResult.OK)
            {
                refresh();
            }
        }

        public void refresh()
        {
            MySqlUtil util = new MySqlUtil();
            List<Users> user_list = util.get_users();

            // 사용자 목록을 데이터 그리드뷰에 바인딩
            this.dataGridView1.DataSource = user_list;
        }
    }
}
