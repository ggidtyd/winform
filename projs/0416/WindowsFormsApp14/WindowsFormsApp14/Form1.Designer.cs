namespace WindowsFormsApp14
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
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.append_button = new System.Windows.Forms.Button();
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.read_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_textBox.Location = new System.Drawing.Point(80, 74);
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(520, 32);
            this.input_textBox.TabIndex = 0;
            // 
            // write_button
            // 
            this.write_button.Location = new System.Drawing.Point(667, 74);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(88, 32);
            this.write_button.TabIndex = 1;
            this.write_button.Text = "쓰기";
            this.write_button.UseVisualStyleBackColor = true;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // append_button
            // 
            this.append_button.Location = new System.Drawing.Point(801, 74);
            this.append_button.Name = "append_button";
            this.append_button.Size = new System.Drawing.Size(193, 32);
            this.append_button.TabIndex = 2;
            this.append_button.Text = "쓰기 (Append)";
            this.append_button.UseVisualStyleBackColor = true;
            this.append_button.Click += new System.EventHandler(this.append_button_Click);
            // 
            // display_textBox
            // 
            this.display_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display_textBox.Location = new System.Drawing.Point(80, 300);
            this.display_textBox.Multiline = true;
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.display_textBox.Size = new System.Drawing.Size(914, 545);
            this.display_textBox.TabIndex = 3;
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(80, 258);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(75, 36);
            this.read_button.TabIndex = 4;
            this.read_button.Text = "읽기";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 919);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.append_button);
            this.Controls.Add(this.write_button);
            this.Controls.Add(this.input_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button append_button;
        private System.Windows.Forms.TextBox display_textBox;
        private System.Windows.Forms.Button read_button;
    }
}

