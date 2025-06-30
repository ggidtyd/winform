using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Final.DB;
using Final.Models;

namespace Final.Forms
{
    public partial class MainForm : Form
    {
        public User loginUser;

        public MainForm(User user)
        {
            InitializeComponent();
            LoadStudents();
            loginUser = user;
            userIdLabel.Text = "안녕하세요 " + loginUser.userId + "님";
            
        }

        private void LoadStudents()
        {
            DataTable dt = DatabaseManager.read();
            dataGridViewStudents.DataSource = dt;
            dataGridViewStudents.Columns["idx"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new StudentForm();
            form.FormClosed += (s, args) => LoadStudents();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
                return;

            int idx = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["idx"].Value);
            string number = dataGridViewStudents.SelectedRows[0].Cells["student_number"].Value.ToString();
            string name = dataGridViewStudents.SelectedRows[0].Cells["name"].Value.ToString();
            string phone = dataGridViewStudents.SelectedRows[0].Cells["phone"].Value.ToString();

            var form = new StudentForm(idx, number, name, phone);
            form.FormClosed += (s, args) => LoadStudents();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0)
                return;

            int idx = Convert.ToInt32(dataGridViewStudents.SelectedRows[0].Cells["idx"].Value);
            DatabaseManager.delete(idx);
            LoadStudents();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
