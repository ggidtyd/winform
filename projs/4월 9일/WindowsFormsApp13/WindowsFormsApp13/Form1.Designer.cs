namespace WindowsFormsApp13
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
            this.read_ini_button = new System.Windows.Forms.Button();
            this.create_write_button = new System.Windows.Forms.Button();
            this.retrieve_file_info_button = new System.Windows.Forms.Button();
            this.driver_list_button = new System.Windows.Forms.Button();
            this.directory_list_button = new System.Windows.Forms.Button();
            this.dir_file_list_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // read_ini_button
            // 
            this.read_ini_button.Location = new System.Drawing.Point(98, 43);
            this.read_ini_button.Name = "read_ini_button";
            this.read_ini_button.Size = new System.Drawing.Size(159, 97);
            this.read_ini_button.TabIndex = 1;
            this.read_ini_button.Text = "read ini";
            this.read_ini_button.UseVisualStyleBackColor = true;
            this.read_ini_button.Click += new System.EventHandler(this.read_ini_button_Click);
            // 
            // create_write_button
            // 
            this.create_write_button.Location = new System.Drawing.Point(287, 43);
            this.create_write_button.Name = "create_write_button";
            this.create_write_button.Size = new System.Drawing.Size(159, 97);
            this.create_write_button.TabIndex = 2;
            this.create_write_button.Text = "create write";
            this.create_write_button.UseVisualStyleBackColor = true;
            this.create_write_button.Click += new System.EventHandler(this.create_write_button_Click);
            // 
            // retrieve_file_info_button
            // 
            this.retrieve_file_info_button.Location = new System.Drawing.Point(476, 43);
            this.retrieve_file_info_button.Name = "retrieve_file_info_button";
            this.retrieve_file_info_button.Size = new System.Drawing.Size(159, 97);
            this.retrieve_file_info_button.TabIndex = 3;
            this.retrieve_file_info_button.Text = "retrieve file info";
            this.retrieve_file_info_button.UseVisualStyleBackColor = true;
            this.retrieve_file_info_button.Click += new System.EventHandler(this.retrieve_file_info_button_Click);
            // 
            // driver_list_button
            // 
            this.driver_list_button.Location = new System.Drawing.Point(665, 43);
            this.driver_list_button.Name = "driver_list_button";
            this.driver_list_button.Size = new System.Drawing.Size(159, 97);
            this.driver_list_button.TabIndex = 4;
            this.driver_list_button.Text = "driver list";
            this.driver_list_button.UseVisualStyleBackColor = true;
            this.driver_list_button.Click += new System.EventHandler(this.driver_list_button_Click);
            // 
            // directory_list_button
            // 
            this.directory_list_button.Location = new System.Drawing.Point(854, 43);
            this.directory_list_button.Name = "directory_list_button";
            this.directory_list_button.Size = new System.Drawing.Size(159, 97);
            this.directory_list_button.TabIndex = 5;
            this.directory_list_button.Text = "directory list";
            this.directory_list_button.UseVisualStyleBackColor = true;
            this.directory_list_button.Click += new System.EventHandler(this.directory_list_button_Click);
            // 
            // dir_file_list_button
            // 
            this.dir_file_list_button.Location = new System.Drawing.Point(1043, 43);
            this.dir_file_list_button.Name = "dir_file_list_button";
            this.dir_file_list_button.Size = new System.Drawing.Size(159, 97);
            this.dir_file_list_button.TabIndex = 6;
            this.dir_file_list_button.Text = "dir file list";
            this.dir_file_list_button.UseVisualStyleBackColor = true;
            this.dir_file_list_button.Click += new System.EventHandler(this.dir_file_list_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(98, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1104, 398);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 643);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dir_file_list_button);
            this.Controls.Add(this.directory_list_button);
            this.Controls.Add(this.driver_list_button);
            this.Controls.Add(this.retrieve_file_info_button);
            this.Controls.Add(this.create_write_button);
            this.Controls.Add(this.read_ini_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_ini_button;
        private System.Windows.Forms.Button create_write_button;
        private System.Windows.Forms.Button retrieve_file_info_button;
        private System.Windows.Forms.Button driver_list_button;
        private System.Windows.Forms.Button directory_list_button;
        private System.Windows.Forms.Button dir_file_list_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}

