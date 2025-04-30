using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        string system_dir = System.Environment.GetEnvironmentVariable("windir");
        string file_name = @"C:\Users\User\Desktop\test.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void read_ini_button_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new StreamReader(system_dir + @"\system.ini");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    textBox1.AppendText(line + "\r\n");
                }
                reader.Close();
            }
            catch
            {
                textBox1.AppendText("empty file");
            }
        }

        private void create_write_button_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\User\Desktop\test.txt";
                StreamWriter writer = new StreamWriter(path);
                writer.WriteLine("안녕하세요.");
                writer.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void retrieve_file_info_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            string path = @"C:\Users\User\Desktop\test.txt";
            string path2 = system_dir + @"\notepad.exe";
            FileInfo info = new FileInfo(path);
            try
            {
                textBox1.AppendText("File Name = " + info.FullName + "\r\n");
                textBox1.AppendText("Creation Time = " + info.CreationTime + "\r\n");
                textBox1.AppendText("Last Access Time = " + info.LastAccessTime + "\r\n");
                textBox1.AppendText("Last Write TIme = " + info.LastWriteTime + "\r\n");
                textBox1.AppendText("Size = " + info.Length);

                info = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void driver_list_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                textBox1.AppendText(drive + "\r\n");
            }

        }

        private void directory_list_button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;

            string[] dirs = Directory.GetDirectories(system_dir);


            foreach (string dir in dirs)
            {
                this.textBox1.AppendText(dir + "\r\n");
            }

        }

        private void dir_file_list_button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;

            string[] files = Directory.GetFiles(system_dir);

            foreach (string i in files)
            {
                this.textBox1.AppendText(i + "\r\n");
            }

        }
    }
}
