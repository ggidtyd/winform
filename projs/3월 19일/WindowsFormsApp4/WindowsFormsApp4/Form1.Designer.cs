namespace WindowsFormsApp4
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
            this.btn_default_msg = new System.Windows.Forms.Button();
            this.btn_title_msg = new System.Windows.Forms.Button();
            this.btn_icon_msg = new System.Windows.Forms.Button();
            this.btn_yesno_msg = new System.Windows.Forms.Button();
            this.btn_yesnocancel_msg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_default_msg
            // 
            this.btn_default_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_default_msg.Location = new System.Drawing.Point(72, 40);
            this.btn_default_msg.Name = "btn_default_msg";
            this.btn_default_msg.Size = new System.Drawing.Size(371, 81);
            this.btn_default_msg.TabIndex = 0;
            this.btn_default_msg.Text = "기본";
            this.btn_default_msg.UseVisualStyleBackColor = true;
            this.btn_default_msg.Click += new System.EventHandler(this.btn_default_msg_Click);
            // 
            // btn_title_msg
            // 
            this.btn_title_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_title_msg.Location = new System.Drawing.Point(72, 154);
            this.btn_title_msg.Name = "btn_title_msg";
            this.btn_title_msg.Size = new System.Drawing.Size(371, 81);
            this.btn_title_msg.TabIndex = 1;
            this.btn_title_msg.Text = "타이틀 메시지 박스";
            this.btn_title_msg.UseVisualStyleBackColor = true;
            this.btn_title_msg.Click += new System.EventHandler(this.btn_title_msg_Click);
            // 
            // btn_icon_msg
            // 
            this.btn_icon_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_icon_msg.Location = new System.Drawing.Point(72, 268);
            this.btn_icon_msg.Name = "btn_icon_msg";
            this.btn_icon_msg.Size = new System.Drawing.Size(371, 81);
            this.btn_icon_msg.TabIndex = 2;
            this.btn_icon_msg.Text = "아이콘 메시지";
            this.btn_icon_msg.UseVisualStyleBackColor = true;
            this.btn_icon_msg.Click += new System.EventHandler(this.btn_icon_msg_Click);
            // 
            // btn_yesno_msg
            // 
            this.btn_yesno_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_yesno_msg.Location = new System.Drawing.Point(72, 382);
            this.btn_yesno_msg.Name = "btn_yesno_msg";
            this.btn_yesno_msg.Size = new System.Drawing.Size(371, 81);
            this.btn_yesno_msg.TabIndex = 3;
            this.btn_yesno_msg.Text = "YesNo 메시지 박스";
            this.btn_yesno_msg.UseVisualStyleBackColor = true;
            this.btn_yesno_msg.Click += new System.EventHandler(this.btn_yesno_msg_Click);
            // 
            // btn_yesnocancel_msg
            // 
            this.btn_yesnocancel_msg.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_yesnocancel_msg.Location = new System.Drawing.Point(72, 496);
            this.btn_yesnocancel_msg.Name = "btn_yesnocancel_msg";
            this.btn_yesnocancel_msg.Size = new System.Drawing.Size(371, 81);
            this.btn_yesnocancel_msg.TabIndex = 4;
            this.btn_yesnocancel_msg.Text = "YesNoCancel 메시지 박스";
            this.btn_yesnocancel_msg.UseVisualStyleBackColor = true;
            this.btn_yesnocancel_msg.Click += new System.EventHandler(this.btn_yesnocancel_msg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 638);
            this.Controls.Add(this.btn_yesnocancel_msg);
            this.Controls.Add(this.btn_yesno_msg);
            this.Controls.Add(this.btn_icon_msg);
            this.Controls.Add(this.btn_title_msg);
            this.Controls.Add(this.btn_default_msg);
            this.Name = "Form1";
            this.Text = "Message Box Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_default_msg;
        private System.Windows.Forms.Button btn_title_msg;
        private System.Windows.Forms.Button btn_icon_msg;
        private System.Windows.Forms.Button btn_yesno_msg;
        private System.Windows.Forms.Button btn_yesnocancel_msg;
    }
}

