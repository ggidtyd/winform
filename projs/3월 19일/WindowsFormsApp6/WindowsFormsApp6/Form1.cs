using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        private int move_step = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_picture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btn_clear_picture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btn_set_background_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료할까요?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void check_box_scrach_CheckedChanged(object sender, EventArgs e)
        {
            if (check_box_scrach.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void move_up_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - move_step);
        }

        private void move_down_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + move_step);
        }

        private void move_right_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + move_step, pictureBox1.Location.Y);
        }

        private void move_left_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - move_step, pictureBox1.Location.Y);
        }

        private void ZoomIn()
        {
            double ZOOM_FACTOR = 1.1;
            int MIN_MAX = 5;

            if ((pictureBox1.Width < (MIN_MAX * pictureBox1.Width)) &&
                (pictureBox1.Height < (MIN_MAX * pictureBox1.Height)))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width * ZOOM_FACTOR);
                pictureBox1.Height = Convert.ToInt32(pictureBox1.Height * ZOOM_FACTOR);
                
            }
        }

        private void ZoomOut()
        {
            double ZOOM_FACTOR = 1.1;
            int MIN_MAX = 5;

            if ((pictureBox1.Width > (pictureBox1.Width / MIN_MAX)) &&
                (pictureBox1.Height > (pictureBox1.Height / MIN_MAX)))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = Convert.ToInt32(pictureBox1.Width / ZOOM_FACTOR);
                pictureBox1.Height = Convert.ToInt32(pictureBox1.Height / ZOOM_FACTOR);
            }
        }

        private void zoom_plus_button_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoom_minus_button_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }
    }
}
