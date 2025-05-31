namespace UserControlEx01
{
    partial class UserControl1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guid_textbox = new System.Windows.Forms.TextBox();
            this.random_textbox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "RANDOM";
            // 
            // guid_textbox
            // 
            this.guid_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guid_textbox.Location = new System.Drawing.Point(98, 38);
            this.guid_textbox.Name = "guid_textbox";
            this.guid_textbox.Size = new System.Drawing.Size(278, 32);
            this.guid_textbox.TabIndex = 2;
            // 
            // random_textbox
            // 
            this.random_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.random_textbox.Location = new System.Drawing.Point(98, 96);
            this.random_textbox.Name = "random_textbox";
            this.random_textbox.Size = new System.Drawing.Size(278, 32);
            this.random_textbox.TabIndex = 3;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(17, 174);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(152, 40);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(224, 174);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(152, 40);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "DELETE";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.random_textbox);
            this.Controls.Add(this.guid_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(404, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guid_textbox;
        private System.Windows.Forms.TextBox random_textbox;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
    }
}
