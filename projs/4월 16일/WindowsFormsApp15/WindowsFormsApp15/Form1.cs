using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder returnedString, uint size, string filePath);

        [DllImport("kernel32.dll")]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

        string file_path = Path.Combine(Environment.CurrentDirectory, "test.ini");

        public Form1()
        {
            InitializeComponent();
        }

        private void write_button_Click(object sender, EventArgs e)
        {
            if (File.Exists(file_path) == false)
            {
                File.Create(file_path);
            }
            string section = section_input.Text;
            string key = key_input.Text;
            string value = value_input.Text;

            WritePrivateProfileString(section, key, value, file_path);

        }
        
        private void read_button_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder { Capacity = 100 };
            string tmp_section = section_read.Text;
            string tmp_key = key_read.Text;

            GetPrivateProfileString(tmp_section, tmp_key, "Nothing..", sb, (uint)sb.Capacity, file_path);
            ini_value_label.Text = sb.ToString();

        }
    }
}
