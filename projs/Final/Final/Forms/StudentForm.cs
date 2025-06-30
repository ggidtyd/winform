using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Final.DB;
using System.Xml.Linq;

namespace Final.Forms
{
    public partial class StudentForm : Form
    {
        private int studentIdx = -1;

        public StudentForm(int idx = -1, string studentNumber = "", string name = "", string phone = "")
        {
            InitializeComponent();
            if (idx != -1)
            {
                studentIdx = idx;
                txtStudentNumber.Text = studentNumber;
                txtName.Text = name;
                txtPhone.Text = phone;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentNumber = txtStudentNumber.Text.Trim();
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (studentNumber == "")
            {
                MessageBox.Show("학번을 입력해주세요");
                return;
            }

            if (studentIdx == -1)
            {
                if (DatabaseManager.duplicateCheck(studentNumber))
                {
                    MessageBox.Show("이미 존재하는 학번입니다.");
                    return;
                }
                DatabaseManager.save(studentNumber, name, phone);
            }
            else
            {
                DatabaseManager.edit(studentIdx, studentNumber, name, phone);
            }
            
            Close();
        }
    }
}

