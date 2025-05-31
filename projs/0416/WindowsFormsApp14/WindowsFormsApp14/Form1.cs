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

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        string file_path = @"C:\Users\User\Desktop\test.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void write_button_Click(object sender, EventArgs e)
        {
            if (!File.Exists(file_path))
            {
                using (var sw = File.CreateText(file_path))
                {
                    sw.WriteLine(input_textBox.Text);
                    sw.Close();
                }
            }
            else
            {
                // 파일이 있다면 Open 모드로 열어 쓰기 한다. 
                try
                {
                    using (var stream = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                    {
                        using (var writer = new StreamWriter(stream))
                        {
                            stream.Position = 0;
                            writer.WriteLine(this.input_textBox.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.display_textBox.AppendText("Exception : " + ex);
                }
            }
        }

        private void append_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (var stream = new FileStream(file_path, FileMode.Append, FileAccess.Write, FileShare.None))
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(input_textBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                display_textBox.AppendText("Exception : " + ex);
            }

        }

        private void read_button_Click(object sender, EventArgs e)
        {
            display_textBox.Text = string.Empty;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(file_path);

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    display_textBox.AppendText(line + "\r\n");
                }

                //close the file
                reader.Close();
            }
            catch (Exception ex)
            {
                display_textBox.AppendText("Exception : " + ex);
            }

        }
    }
}
