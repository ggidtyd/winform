namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_show_picture = new System.Windows.Forms.Button();
            this.btn_clear_picture = new System.Windows.Forms.Button();
            this.btn_set_background = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoom_minus_button = new System.Windows.Forms.Button();
            this.zoom_plus_button = new System.Windows.Forms.Button();
            this.move_left = new System.Windows.Forms.Button();
            this.move_down = new System.Windows.Forms.Button();
            this.move_right = new System.Windows.Forms.Button();
            this.move_up = new System.Windows.Forms.Button();
            this.check_box_scrach = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1781, 1240);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_show_picture);
            this.flowLayoutPanel1.Controls.Add(this.btn_clear_picture);
            this.flowLayoutPanel1.Controls.Add(this.btn_set_background);
            this.flowLayoutPanel1.Controls.Add(this.btn_close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(407, 1063);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1371, 174);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_show_picture
            // 
            this.btn_show_picture.Location = new System.Drawing.Point(1161, 3);
            this.btn_show_picture.Name = "btn_show_picture";
            this.btn_show_picture.Size = new System.Drawing.Size(207, 50);
            this.btn_show_picture.TabIndex = 0;
            this.btn_show_picture.Text = "show a picture";
            this.btn_show_picture.UseVisualStyleBackColor = true;
            this.btn_show_picture.Click += new System.EventHandler(this.btn_show_picture_Click);
            // 
            // btn_clear_picture
            // 
            this.btn_clear_picture.Location = new System.Drawing.Point(915, 3);
            this.btn_clear_picture.Name = "btn_clear_picture";
            this.btn_clear_picture.Size = new System.Drawing.Size(240, 50);
            this.btn_clear_picture.TabIndex = 1;
            this.btn_clear_picture.Text = "clear the picture";
            this.btn_clear_picture.UseVisualStyleBackColor = true;
            this.btn_clear_picture.Click += new System.EventHandler(this.btn_clear_picture_Click);
            // 
            // btn_set_background
            // 
            this.btn_set_background.Location = new System.Drawing.Point(657, 3);
            this.btn_set_background.Name = "btn_set_background";
            this.btn_set_background.Size = new System.Drawing.Size(252, 50);
            this.btn_set_background.TabIndex = 2;
            this.btn_set_background.Text = "set the background";
            this.btn_set_background.UseVisualStyleBackColor = true;
            this.btn_set_background.Click += new System.EventHandler(this.btn_set_background_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(505, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(146, 50);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.zoom_minus_button);
            this.panel1.Controls.Add(this.zoom_plus_button);
            this.panel1.Controls.Add(this.move_left);
            this.panel1.Controls.Add(this.move_down);
            this.panel1.Controls.Add(this.move_right);
            this.panel1.Controls.Add(this.move_up);
            this.panel1.Controls.Add(this.check_box_scrach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 1063);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 174);
            this.panel1.TabIndex = 3;
            // 
            // zoom_minus_button
            // 
            this.zoom_minus_button.Location = new System.Drawing.Point(218, 102);
            this.zoom_minus_button.Name = "zoom_minus_button";
            this.zoom_minus_button.Size = new System.Drawing.Size(155, 42);
            this.zoom_minus_button.TabIndex = 6;
            this.zoom_minus_button.Text = "zoom -";
            this.zoom_minus_button.UseVisualStyleBackColor = true;
            this.zoom_minus_button.Click += new System.EventHandler(this.zoom_minus_button_Click);
            // 
            // zoom_plus_button
            // 
            this.zoom_plus_button.Location = new System.Drawing.Point(218, 43);
            this.zoom_plus_button.Name = "zoom_plus_button";
            this.zoom_plus_button.Size = new System.Drawing.Size(155, 42);
            this.zoom_plus_button.TabIndex = 5;
            this.zoom_plus_button.Text = "zoom +";
            this.zoom_plus_button.UseVisualStyleBackColor = true;
            this.zoom_plus_button.Click += new System.EventHandler(this.zoom_plus_button_Click);
            // 
            // move_left
            // 
            this.move_left.Location = new System.Drawing.Point(53, 85);
            this.move_left.Name = "move_left";
            this.move_left.Size = new System.Drawing.Size(39, 33);
            this.move_left.TabIndex = 4;
            this.move_left.Text = "◁";
            this.move_left.UseVisualStyleBackColor = true;
            this.move_left.Click += new System.EventHandler(this.move_left_Click);
            // 
            // move_down
            // 
            this.move_down.Location = new System.Drawing.Point(98, 121);
            this.move_down.Name = "move_down";
            this.move_down.Size = new System.Drawing.Size(39, 33);
            this.move_down.TabIndex = 3;
            this.move_down.Text = "▽";
            this.move_down.UseVisualStyleBackColor = true;
            this.move_down.Click += new System.EventHandler(this.move_down_Click);
            // 
            // move_right
            // 
            this.move_right.Location = new System.Drawing.Point(143, 85);
            this.move_right.Name = "move_right";
            this.move_right.Size = new System.Drawing.Size(39, 33);
            this.move_right.TabIndex = 2;
            this.move_right.Text = "▷";
            this.move_right.UseVisualStyleBackColor = true;
            this.move_right.Click += new System.EventHandler(this.move_right_Click);
            // 
            // move_up
            // 
            this.move_up.Location = new System.Drawing.Point(98, 46);
            this.move_up.Name = "move_up";
            this.move_up.Size = new System.Drawing.Size(39, 33);
            this.move_up.TabIndex = 1;
            this.move_up.Text = "△";
            this.move_up.UseVisualStyleBackColor = true;
            this.move_up.Click += new System.EventHandler(this.move_up_Click);
            // 
            // check_box_scrach
            // 
            this.check_box_scrach.AutoSize = true;
            this.check_box_scrach.Location = new System.Drawing.Point(14, 4);
            this.check_box_scrach.Name = "check_box_scrach";
            this.check_box_scrach.Size = new System.Drawing.Size(96, 25);
            this.check_box_scrach.TabIndex = 0;
            this.check_box_scrach.Text = "Scrach";
            this.check_box_scrach.UseVisualStyleBackColor = true;
            this.check_box_scrach.CheckedChanged += new System.EventHandler(this.check_box_scrach_CheckedChanged);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1775, 1054);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1775, 1048);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 1240);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_show_picture;
        private System.Windows.Forms.Button btn_clear_picture;
        private System.Windows.Forms.Button btn_set_background;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox check_box_scrach;
        private System.Windows.Forms.Button move_up;
        private System.Windows.Forms.Button zoom_minus_button;
        private System.Windows.Forms.Button zoom_plus_button;
        private System.Windows.Forms.Button move_left;
        private System.Windows.Forms.Button move_down;
        private System.Windows.Forms.Button move_right;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

