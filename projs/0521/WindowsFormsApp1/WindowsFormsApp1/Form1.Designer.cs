namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop_all_button = new System.Windows.Forms.Button();
            this.run_all_button = new System.Windows.Forms.Button();
            this.cnt_label = new System.Windows.Forms.Label();
            this.update_all_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stop_all_button);
            this.panel1.Controls.Add(this.run_all_button);
            this.panel1.Controls.Add(this.cnt_label);
            this.panel1.Controls.Add(this.update_all_button);
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 100);
            this.panel1.TabIndex = 0;
            // 
            // stop_all_button
            // 
            this.stop_all_button.Location = new System.Drawing.Point(684, 3);
            this.stop_all_button.Name = "stop_all_button";
            this.stop_all_button.Size = new System.Drawing.Size(127, 90);
            this.stop_all_button.TabIndex = 5;
            this.stop_all_button.Text = "STOP ALL";
            this.stop_all_button.UseVisualStyleBackColor = true;
            this.stop_all_button.Click += new System.EventHandler(this.stop_all_button_Click);
            // 
            // run_all_button
            // 
            this.run_all_button.Location = new System.Drawing.Point(567, 4);
            this.run_all_button.Name = "run_all_button";
            this.run_all_button.Size = new System.Drawing.Size(111, 90);
            this.run_all_button.TabIndex = 4;
            this.run_all_button.Text = "RUN ALL";
            this.run_all_button.UseVisualStyleBackColor = true;
            this.run_all_button.Click += new System.EventHandler(this.run_all_button_Click);
            // 
            // cnt_label
            // 
            this.cnt_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cnt_label.AutoSize = true;
            this.cnt_label.Location = new System.Drawing.Point(1153, 38);
            this.cnt_label.Name = "cnt_label";
            this.cnt_label.Size = new System.Drawing.Size(81, 21);
            this.cnt_label.TabIndex = 3;
            this.cnt_label.Text = "총 00개";
            // 
            // update_all_button
            // 
            this.update_all_button.Location = new System.Drawing.Point(254, 3);
            this.update_all_button.Name = "update_all_button";
            this.update_all_button.Size = new System.Drawing.Size(181, 90);
            this.update_all_button.TabIndex = 2;
            this.update_all_button.Text = "UPDATE ALL";
            this.update_all_button.UseVisualStyleBackColor = true;
            this.update_all_button.Click += new System.EventHandler(this.update_all_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(137, 3);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(111, 90);
            this.clear_button.TabIndex = 1;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(20, 3);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(111, 90);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1247, 798);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 898);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label cnt_label;
        private System.Windows.Forms.Button update_all_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button stop_all_button;
        private System.Windows.Forms.Button run_all_button;
    }
}

