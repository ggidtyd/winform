namespace WindowsFormsApp12
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackbar_red = new System.Windows.Forms.TrackBar();
            this.trackbar_green = new System.Windows.Forms.TrackBar();
            this.trackbar_blue = new System.Windows.Forms.TrackBar();
            this.trackbar_alpha = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.auto_button = new System.Windows.Forms.Button();
            this.manual_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_alpha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(91, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 233);
            this.panel1.TabIndex = 0;
            // 
            // trackbar_red
            // 
            this.trackbar_red.Location = new System.Drawing.Point(200, 310);
            this.trackbar_red.Maximum = 255;
            this.trackbar_red.Name = "trackbar_red";
            this.trackbar_red.Size = new System.Drawing.Size(482, 80);
            this.trackbar_red.TabIndex = 0;
            this.trackbar_red.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            // 
            // trackbar_green
            // 
            this.trackbar_green.Location = new System.Drawing.Point(200, 390);
            this.trackbar_green.Maximum = 255;
            this.trackbar_green.Name = "trackbar_green";
            this.trackbar_green.Size = new System.Drawing.Size(482, 80);
            this.trackbar_green.TabIndex = 1;
            this.trackbar_green.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            // 
            // trackbar_blue
            // 
            this.trackbar_blue.Location = new System.Drawing.Point(200, 470);
            this.trackbar_blue.Maximum = 255;
            this.trackbar_blue.Name = "trackbar_blue";
            this.trackbar_blue.Size = new System.Drawing.Size(482, 80);
            this.trackbar_blue.TabIndex = 2;
            this.trackbar_blue.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            // 
            // trackbar_alpha
            // 
            this.trackbar_alpha.Location = new System.Drawing.Point(200, 550);
            this.trackbar_alpha.Maximum = 255;
            this.trackbar_alpha.Name = "trackbar_alpha";
            this.trackbar_alpha.Size = new System.Drawing.Size(482, 80);
            this.trackbar_alpha.TabIndex = 3;
            this.trackbar_alpha.ValueChanged += new System.EventHandler(this.trackbar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "투명도";
            // 
            // auto_button
            // 
            this.auto_button.Location = new System.Drawing.Point(108, 642);
            this.auto_button.Name = "auto_button";
            this.auto_button.Size = new System.Drawing.Size(236, 100);
            this.auto_button.TabIndex = 7;
            this.auto_button.Text = "auto";
            this.auto_button.UseVisualStyleBackColor = true;
            this.auto_button.Click += new System.EventHandler(this.auto_button_Click);
            // 
            // manual_button
            // 
            this.manual_button.Location = new System.Drawing.Point(446, 636);
            this.manual_button.Name = "manual_button";
            this.manual_button.Size = new System.Drawing.Size(236, 100);
            this.manual_button.TabIndex = 8;
            this.manual_button.Text = "manual";
            this.manual_button.UseVisualStyleBackColor = true;
            this.manual_button.Click += new System.EventHandler(this.manual_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 779);
            this.Controls.Add(this.manual_button);
            this.Controls.Add(this.auto_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackbar_alpha);
            this.Controls.Add(this.trackbar_blue);
            this.Controls.Add(this.trackbar_green);
            this.Controls.Add(this.trackbar_red);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_alpha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackbar_red;
        private System.Windows.Forms.TrackBar trackbar_green;
        private System.Windows.Forms.TrackBar trackbar_blue;
        private System.Windows.Forms.TrackBar trackbar_alpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button auto_button;
        private System.Windows.Forms.Button manual_button;
        private System.Windows.Forms.Timer timer1;
    }
}

