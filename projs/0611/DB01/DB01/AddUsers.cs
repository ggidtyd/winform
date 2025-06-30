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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            string uid = id_input_text_box.Text;
            string pwd = pw_input_text_box.Text;
            string user_name = name_input_text_box.Text;

            MySqlUtil util = new MySqlUtil();
            int result = util.add_user(uid, pwd, user_name);

            if (result == 1)
            {
                MessageBox.Show("추가했습니다.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
