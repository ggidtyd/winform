namespace WindowsFormsApp11
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
            this.onoff_button = new System.Windows.Forms.Button();
            this.blink_button = new System.Windows.Forms.Button();
            this.onoff_lamp = new System.Windows.Forms.Button();
            this.blink_lamp = new System.Windows.Forms.Button();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.SuspendLayout();
            // 
            // onoff_button
            // 
            this.onoff_button.Location = new System.Drawing.Point(90, 52);
            this.onoff_button.Name = "onoff_button";
            this.onoff_button.Size = new System.Drawing.Size(181, 114);
            this.onoff_button.TabIndex = 1;
            this.onoff_button.Text = "꺼짐켜짐(Toggle)";
            this.onoff_button.UseVisualStyleBackColor = true;
            this.onoff_button.Click += new System.EventHandler(this.onoff_button_Click);
            // 
            // blink_button
            // 
            this.blink_button.Location = new System.Drawing.Point(90, 212);
            this.blink_button.Name = "blink_button";
            this.blink_button.Size = new System.Drawing.Size(181, 114);
            this.blink_button.TabIndex = 2;
            this.blink_button.Text = "깜빡깜빡";
            this.blink_button.UseVisualStyleBackColor = true;
            this.blink_button.Click += new System.EventHandler(this.blink_button_Click);
            // 
            // onoff_lamp
            // 
            this.onoff_lamp.BackColor = System.Drawing.Color.Red;
            this.onoff_lamp.Location = new System.Drawing.Point(448, 52);
            this.onoff_lamp.Name = "onoff_lamp";
            this.onoff_lamp.Size = new System.Drawing.Size(181, 114);
            this.onoff_lamp.TabIndex = 3;
            this.onoff_lamp.Text = "Lamp1";
            this.onoff_lamp.UseVisualStyleBackColor = false;
            // 
            // blink_lamp
            // 
            this.blink_lamp.BackColor = System.Drawing.Color.Blue;
            this.blink_lamp.Location = new System.Drawing.Point(448, 212);
            this.blink_lamp.Name = "blink_lamp";
            this.blink_lamp.Size = new System.Drawing.Size(181, 114);
            this.blink_lamp.TabIndex = 4;
            this.blink_lamp.Text = "Lamp2";
            this.blink_lamp.UseVisualStyleBackColor = false;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(90, 362);
            this.interval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(120, 32);
            this.interval.TabIndex = 5;
            this.interval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "m/s";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(290, 212);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(120, 114);
            this.stop_button.TabIndex = 7;
            this.stop_button.Text = "정지";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.blink_lamp);
            this.Controls.Add(this.onoff_lamp);
            this.Controls.Add(this.blink_button);
            this.Controls.Add(this.onoff_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onoff_button;
        private System.Windows.Forms.Button blink_button;
        private System.Windows.Forms.Button onoff_lamp;
        private System.Windows.Forms.Button blink_lamp;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stop_button;
    }
}

