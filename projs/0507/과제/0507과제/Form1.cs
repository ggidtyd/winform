using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0507과제
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
            init_grid();
        }

        public void init_grid()
        {
            if (dt.Columns.Count > 1)
            {
                MessageBox.Show("이미 GridView에 열이 있습니다.");
                return;
            }

            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");
            dt.Columns.Add("주소");
            dt.Columns.Add("학점");

            dataGridView1.DataSource = dt;
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (dt.Columns.Count == 0)
            {
                MessageBox.Show("열이 없습니다.");
                return;
            }

            string id = id_text_box.Text;
            string name = name_text_box.Text;
            string phone = phone_text_box.Text;
            string addr = address_text_box.Text;
            string gpa = gpa_text_box.Text;

            foreach (DataRow row in dt.Rows)
            {
                if (row["학번"].ToString() == id)
                {
                    MessageBox.Show("이미 등록된 학생입니다");
                    return;
                }
            }

            if(id == "")
            {
                MessageBox.Show("학번을 입력하세요");
                return;
            }
            if (name == "")
            {
                MessageBox.Show("이름을 입력하세요");
                return;
            }
            if (phone == "")
            {
                MessageBox.Show("전화번호를 입력하세요");
                return;
            }
            if (addr == "")
            {
                MessageBox.Show("주소를 입력하세요");
                return;
            }
            if (gpa == "")
            {
                MessageBox.Show("학점을 입력하세요");
                return;
            }

            dt.Rows.Add(id, name, phone, addr, gpa);

            id_text_box.Text = "";
            name_text_box.Text = "";
            phone_text_box.Text = "";
            address_text_box.Text = "";
            gpa_text_box.Text = "";
        }

        public void edit()
        {
            string id = id_text_box.Text;

            if (id == "")
            {
                MessageBox.Show("학생을 조회하고 수정하세요");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                if (row["학번"].ToString() == id)
                {
                    row["학번"] = id_text_box.Text;
                    row["이름"] = name_text_box.Text;
                    row["전화번호"] = phone_text_box.Text;
                    row["주소"] = address_text_box.Text;
                    row["학점"] = gpa_text_box.Text;

                    MessageBox.Show("수정했습니다");
                }
            }
        }

        public void delete()
        {
            int selected_row_cnt = dataGridView1.SelectedRows.Count;

            if (selected_row_cnt == 0)
            {
                MessageBox.Show("삭제할 행을 선택해주세요.");
                return;
            }

            string id = "";
            string name = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = (string)row.Cells["학번"].Value;
                name = (string)row.Cells["이름"].Value;
            }

            if (DialogResult.OK == MessageBox.Show($"학번 : {id} 이름 : {name} 학생을 정말 삭제 할까요?", "경고", MessageBoxButtons.OKCancel))
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            int select_row_cnt = dataGridView1.SelectedRows.Count;

            if (select_row_cnt == 0)
            {
                MessageBox.Show("조회할 행을 선택해주세요.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = (string)row.Cells["학번"].Value;
                string name = (string)row.Cells["이름"].Value;
                string phone = (string)row.Cells["전화번호"].Value;
                string addr = (string)row.Cells["주소"].Value;
                string gpa = (string)row.Cells["학점"].Value;

                id_text_box.Text = id;
                name_text_box.Text = name;
                phone_text_box.Text = phone;
                address_text_box.Text = addr;
                gpa_text_box.Text = gpa;
            }
        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }
    }
}
