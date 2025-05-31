namespace WindowsFormsApp5
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userid_input = new System.Windows.Forms.TextBox();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Id";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(175, 187);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(109, 57);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // userid_input
            // 
            this.userid_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userid_input.Location = new System.Drawing.Point(175, 48);
            this.userid_input.MaxLength = 15;
            this.userid_input.Name = "userid_input";
            this.userid_input.Size = new System.Drawing.Size(243, 32);
            this.userid_input.TabIndex = 0;
            // 
            // pw_input
            // 
            this.pw_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pw_input.Location = new System.Drawing.Point(175, 115);
            this.pw_input.MaxLength = 15;
            this.pw_input.Name = "pw_input";
            this.pw_input.PasswordChar = '*';
            this.pw_input.Size = new System.Drawing.Size(243, 32);
            this.pw_input.TabIndex = 1;
            this.pw_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_input_KeyDown);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(309, 187);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(109, 57);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.ControlBox = false;
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.userid_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userid_input;
        private System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Button close_button;
    }
}

