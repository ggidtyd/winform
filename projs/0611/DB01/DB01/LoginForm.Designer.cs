namespace DB01
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.id_input_text_box = new System.Windows.Forms.TextBox();
            this.pw_input_text_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.cancle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // id_input_text_box
            // 
            this.id_input_text_box.Location = new System.Drawing.Point(109, 42);
            this.id_input_text_box.Name = "id_input_text_box";
            this.id_input_text_box.Size = new System.Drawing.Size(241, 32);
            this.id_input_text_box.TabIndex = 1;
            // 
            // pw_input_text_box
            // 
            this.pw_input_text_box.Location = new System.Drawing.Point(109, 132);
            this.pw_input_text_box.Name = "pw_input_text_box";
            this.pw_input_text_box.Size = new System.Drawing.Size(241, 32);
            this.pw_input_text_box.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(110, 196);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(117, 43);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // cancle_button
            // 
            this.cancle_button.Location = new System.Drawing.Point(233, 196);
            this.cancle_button.Name = "cancle_button";
            this.cancle_button.Size = new System.Drawing.Size(117, 43);
            this.cancle_button.TabIndex = 4;
            this.cancle_button.Text = "Cancle";
            this.cancle_button.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 262);
            this.Controls.Add(this.cancle_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_input_text_box);
            this.Controls.Add(this.id_input_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_input_text_box;
        private System.Windows.Forms.TextBox pw_input_text_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button cancle_button;
    }
}