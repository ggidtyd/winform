namespace WindowsFormsApp8
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
            this.components = new System.ComponentModel.Container();
            this.random_button = new System.Windows.Forms.Button();
            this.label_10 = new System.Windows.Forms.Label();
            this.label_100 = new System.Windows.Forms.Label();
            this.label_1000 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // random_button
            // 
            this.random_button.Location = new System.Drawing.Point(144, 131);
            this.random_button.Name = "random_button";
            this.random_button.Size = new System.Drawing.Size(142, 104);
            this.random_button.TabIndex = 0;
            this.random_button.Text = "Random";
            this.random_button.UseVisualStyleBackColor = true;
            this.random_button.Click += new System.EventHandler(this.random_button_Click);
            // 
            // label_10
            // 
            this.label_10.AutoSize = true;
            this.label_10.Location = new System.Drawing.Point(572, 114);
            this.label_10.Name = "label_10";
            this.label_10.Size = new System.Drawing.Size(73, 21);
            this.label_10.TabIndex = 1;
            this.label_10.Text = "1 ~ 10";
            // 
            // label_100
            // 
            this.label_100.AutoSize = true;
            this.label_100.Location = new System.Drawing.Point(572, 173);
            this.label_100.Name = "label_100";
            this.label_100.Size = new System.Drawing.Size(84, 21);
            this.label_100.TabIndex = 2;
            this.label_100.Text = "1 ~ 100";
            // 
            // label_1000
            // 
            this.label_1000.AutoSize = true;
            this.label_1000.Location = new System.Drawing.Point(572, 232);
            this.label_1000.Name = "label_1000";
            this.label_1000.Size = new System.Drawing.Size(95, 21);
            this.label_1000.TabIndex = 3;
            this.label_1000.Text = "1 ~ 1000";
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(303, 131);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(138, 104);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(303, 256);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(138, 86);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 405);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label_1000);
            this.Controls.Add(this.label_100);
            this.Controls.Add(this.label_10);
            this.Controls.Add(this.random_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button random_button;
        private System.Windows.Forms.Label label_10;
        private System.Windows.Forms.Label label_100;
        private System.Windows.Forms.Label label_1000;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop_button;
    }
}

