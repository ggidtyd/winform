namespace DB01
{
    partial class AddUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.id_input_text_box = new System.Windows.Forms.TextBox();
            this.pw_input_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_input_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_user_button = new System.Windows.Forms.Button();
            this.cancle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // id_input_text_box
            // 
            this.id_input_text_box.Location = new System.Drawing.Point(121, 36);
            this.id_input_text_box.Name = "id_input_text_box";
            this.id_input_text_box.Size = new System.Drawing.Size(258, 32);
            this.id_input_text_box.TabIndex = 1;
            // 
            // pw_input_text_box
            // 
            this.pw_input_text_box.Location = new System.Drawing.Point(121, 79);
            this.pw_input_text_box.Name = "pw_input_text_box";
            this.pw_input_text_box.Size = new System.Drawing.Size(258, 32);
            this.pw_input_text_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "비밀번호";
            // 
            // name_input_text_box
            // 
            this.name_input_text_box.Location = new System.Drawing.Point(121, 123);
            this.name_input_text_box.Name = "name_input_text_box";
            this.name_input_text_box.Size = new System.Drawing.Size(258, 32);
            this.name_input_text_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름";
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(45, 196);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(109, 48);
            this.add_user_button.TabIndex = 6;
            this.add_user_button.Text = "추가";
            this.add_user_button.UseVisualStyleBackColor = true;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // cancle_button
            // 
            this.cancle_button.Location = new System.Drawing.Point(270, 196);
            this.cancle_button.Name = "cancle_button";
            this.cancle_button.Size = new System.Drawing.Size(109, 48);
            this.cancle_button.TabIndex = 7;
            this.cancle_button.Text = "취소";
            this.cancle_button.UseVisualStyleBackColor = true;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 276);
            this.Controls.Add(this.cancle_button);
            this.Controls.Add(this.add_user_button);
            this.Controls.Add(this.name_input_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw_input_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_input_text_box);
            this.Controls.Add(this.label1);
            this.Name = "AddUsers";
            this.Text = "AddUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_input_text_box;
        private System.Windows.Forms.TextBox pw_input_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_input_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.Button cancle_button;
    }
}