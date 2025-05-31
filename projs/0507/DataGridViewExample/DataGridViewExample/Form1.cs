using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
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
            if(dt.Columns.Count > 1)
            {
                MessageBox.Show("이미 GridView에 열이 있습니다.");
                return;
            }

            dt.Columns.Add("PID")
                .Caption = "PID";
            dt.Columns.Add("Category")
                .Caption = "분류";
            dt.Columns.Add("Item")
                .Caption = "품목";
            dt.Columns.Add("Price")
                .Caption = "가격";
            dt.Columns.Add("Stock")
                .Caption = "재고";

            dataGridView1.DataSource = dt;
        }

        private void data_add_button_Click(object sender, EventArgs e)
        {
            if(dt.Columns.Count == 0)
            {
                MessageBox.Show("열이 없습니다.");
                return;
            }
            
            Guid guid = Guid.NewGuid();

            string tmp_guid = guid.ToString();

            String text1 = col1_text_box.Text;
            String text2 = col2_text_box.Text;
            String text3 = col3_text_box.Text;
            String text4 = col4_text_box.Text;


            dt.Rows.Add(tmp_guid, text1, text2, text3, text4);

            col1_text_box.Text = "";
            col2_text_box.Text = "";
            col3_text_box.Text = "";
            col4_text_box.Text = "";
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            string pid = pid_show_label.Text;

            if(pid == "")
            {
                MessageBox.Show("PID가 없어서 수정 불가합니다.");
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                if (row["PID"].ToString() == pid)
                {
                    row["Category"] = col1_text_box.Text;
                    row["Item"] = col2_text_box.Text;
                    row["Price"] = col3_text_box.Text;
                    row["Stock"] = col4_text_box.Text;

                    MessageBox.Show("수정했습니다");
                }
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete();
        }

        public void copy()
        {
            int select_row_cnt = dataGridView1.SelectedRows.Count;

            if (select_row_cnt == 0)
            {
                MessageBox.Show("복사할 행을 선택해주세요.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string pid = (string)row.Cells["PID"].Value;
                string category = (string)row.Cells["Category"].Value;
                string item = (string)row.Cells["Item"].Value;
                string price = (string)row.Cells["Price"].Value;
                string stock = (string)row.Cells["Stock"].Value;

                pid_show_label.Text = pid;
                col1_text_box.Text = category;
                col2_text_box.Text = item;
                col3_text_box.Text = price;
                col4_text_box.Text = stock;
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

            if (DialogResult.OK == MessageBox.Show("정말 삭제 할까요?", "경고", MessageBoxButtons.OKCancel))
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void grid_col_create_button_Click(object sender, EventArgs e)
        {
            init_grid();
        }
    }
}
