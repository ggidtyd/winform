namespace WindowsFormsApp15
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.section_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.key_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.value_input = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.section_read = new System.Windows.Forms.TextBox();
            this.key_read = new System.Windows.Forms.TextBox();
            this.read_button = new System.Windows.Forms.Button();
            this.ini_value_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.write_button);
            this.groupBox1.Controls.Add(this.value_input);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.key_input);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.section_input);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(63, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INI 입력하기";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "SECTION";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ini_value_label);
            this.groupBox2.Controls.Add(this.read_button);
            this.groupBox2.Controls.Add(this.key_read);
            this.groupBox2.Controls.Add(this.section_read);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(63, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INI 값 가져오기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECTION";
            // 
            // section_input
            // 
            this.section_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.section_input.Location = new System.Drawing.Point(40, 76);
            this.section_input.Name = "section_input";
            this.section_input.Size = new System.Drawing.Size(182, 32);
            this.section_input.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "KEY";
            // 
            // key_input
            // 
            this.key_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.key_input.Location = new System.Drawing.Point(295, 76);
            this.key_input.Name = "key_input";
            this.key_input.Size = new System.Drawing.Size(182, 32);
            this.key_input.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "VALUE";
            // 
            // value_input
            // 
            this.value_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_input.Location = new System.Drawing.Point(550, 76);
            this.value_input.Name = "value_input";
            this.value_input.Size = new System.Drawing.Size(182, 32);
            this.value_input.TabIndex = 6;
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(631, 133);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(101, 61);
            this.write_button.TabIndex = 7;
            this.write_button.Text = "입력";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "KEY";
            // 
            // section_read
            // 
            this.section_read.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.section_read.Location = new System.Drawing.Point(153, 90);
            this.section_read.Name = "section_read";
            this.section_read.Size = new System.Drawing.Size(182, 32);
            this.section_read.TabIndex = 8;
            // 
            // key_read
            // 
            this.key_read.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.key_read.Location = new System.Drawing.Point(153, 172);
            this.key_read.Name = "key_read";
            this.key_read.Size = new System.Drawing.Size(182, 32);
            this.key_read.TabIndex = 9;
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(233, 226);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(102, 42);
            this.read_button.TabIndex = 8;
            this.read_button.Text = "조회";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // ini_value_label
            // 
            this.ini_value_label.AutoSize = true;
            this.ini_value_label.Font = new System.Drawing.Font("굴림", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ini_value_label.Location = new System.Drawing.Point(390, 120);
            this.ini_value_label.Name = "ini_value_label";
            this.ini_value_label.Size = new System.Drawing.Size(68, 48);
            this.ini_value_label.TabIndex = 10;
            this.ini_value_label.Text = "값";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.TextBox value_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox key_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox section_input;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.TextBox key_read;
        private System.Windows.Forms.TextBox section_read;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ini_value_label;
    }
}

