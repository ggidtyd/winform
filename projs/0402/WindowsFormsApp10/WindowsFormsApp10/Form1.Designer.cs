namespace WindowsFormsApp10
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
            this.label1 = new System.Windows.Forms.Label();
            this.time_left_label = new System.Windows.Forms.Label();
            this.plus_label1 = new System.Windows.Forms.Label();
            this.plus_label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minus_label2 = new System.Windows.Forms.Label();
            this.minus_label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mul_label2 = new System.Windows.Forms.Label();
            this.mul_label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.div_label2 = new System.Windows.Forms.Label();
            this.div_label1 = new System.Windows.Forms.Label();
            this.plus_input = new System.Windows.Forms.NumericUpDown();
            this.minus_input = new System.Windows.Forms.NumericUpDown();
            this.mul_input = new System.Windows.Forms.NumericUpDown();
            this.div_input = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plus_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mul_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.div_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "남은 시간 :";
            // 
            // time_left_label
            // 
            this.time_left_label.AutoSize = true;
            this.time_left_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_left_label.Location = new System.Drawing.Point(524, 46);
            this.time_left_label.MinimumSize = new System.Drawing.Size(20, 0);
            this.time_left_label.Name = "time_left_label";
            this.time_left_label.Size = new System.Drawing.Size(23, 23);
            this.time_left_label.TabIndex = 1;
            this.time_left_label.Text = "0";
            // 
            // plus_label1
            // 
            this.plus_label1.AutoSize = true;
            this.plus_label1.Location = new System.Drawing.Point(256, 193);
            this.plus_label1.Name = "plus_label1";
            this.plus_label1.Size = new System.Drawing.Size(21, 21);
            this.plus_label1.TabIndex = 2;
            this.plus_label1.Text = "?";
            // 
            // plus_label2
            // 
            this.plus_label2.AutoSize = true;
            this.plus_label2.Location = new System.Drawing.Point(550, 193);
            this.plus_label2.Name = "plus_label2";
            this.plus_label2.Size = new System.Drawing.Size(21, 21);
            this.plus_label2.TabIndex = 3;
            this.plus_label2.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            // 
            // minus_label2
            // 
            this.minus_label2.AutoSize = true;
            this.minus_label2.Location = new System.Drawing.Point(550, 267);
            this.minus_label2.Name = "minus_label2";
            this.minus_label2.Size = new System.Drawing.Size(21, 21);
            this.minus_label2.TabIndex = 12;
            this.minus_label2.Text = "?";
            // 
            // minus_label1
            // 
            this.minus_label1.AutoSize = true;
            this.minus_label1.Location = new System.Drawing.Point(256, 267);
            this.minus_label1.Name = "minus_label1";
            this.minus_label1.Size = new System.Drawing.Size(21, 21);
            this.minus_label1.TabIndex = 11;
            this.minus_label1.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "X";
            // 
            // mul_label2
            // 
            this.mul_label2.AutoSize = true;
            this.mul_label2.Location = new System.Drawing.Point(550, 341);
            this.mul_label2.Name = "mul_label2";
            this.mul_label2.Size = new System.Drawing.Size(21, 21);
            this.mul_label2.TabIndex = 15;
            this.mul_label2.Text = "?";
            // 
            // mul_label1
            // 
            this.mul_label1.AutoSize = true;
            this.mul_label1.Location = new System.Drawing.Point(256, 341);
            this.mul_label1.Name = "mul_label1";
            this.mul_label1.Size = new System.Drawing.Size(21, 21);
            this.mul_label1.TabIndex = 14;
            this.mul_label1.Text = "?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 415);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "/";
            // 
            // div_label2
            // 
            this.div_label2.AutoSize = true;
            this.div_label2.Location = new System.Drawing.Point(550, 415);
            this.div_label2.Name = "div_label2";
            this.div_label2.Size = new System.Drawing.Size(21, 21);
            this.div_label2.TabIndex = 18;
            this.div_label2.Text = "?";
            // 
            // div_label1
            // 
            this.div_label1.AutoSize = true;
            this.div_label1.Location = new System.Drawing.Point(256, 415);
            this.div_label1.Name = "div_label1";
            this.div_label1.Size = new System.Drawing.Size(21, 21);
            this.div_label1.TabIndex = 17;
            this.div_label1.Text = "?";
            // 
            // plus_input
            // 
            this.plus_input.Location = new System.Drawing.Point(625, 191);
            this.plus_input.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.plus_input.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.plus_input.Name = "plus_input";
            this.plus_input.Size = new System.Drawing.Size(120, 32);
            this.plus_input.TabIndex = 20;
            // 
            // minus_input
            // 
            this.minus_input.Location = new System.Drawing.Point(625, 256);
            this.minus_input.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.minus_input.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.minus_input.Name = "minus_input";
            this.minus_input.Size = new System.Drawing.Size(120, 32);
            this.minus_input.TabIndex = 21;
            // 
            // mul_input
            // 
            this.mul_input.Location = new System.Drawing.Point(625, 330);
            this.mul_input.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.mul_input.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.mul_input.Name = "mul_input";
            this.mul_input.Size = new System.Drawing.Size(120, 32);
            this.mul_input.TabIndex = 22;
            // 
            // div_input
            // 
            this.div_input.Location = new System.Drawing.Point(625, 404);
            this.div_input.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.div_input.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.div_input.Name = "div_input";
            this.div_input.Size = new System.Drawing.Size(120, 32);
            this.div_input.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(383, 478);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(234, 69);
            this.start_button.TabIndex = 24;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 585);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.div_input);
            this.Controls.Add(this.mul_input);
            this.Controls.Add(this.minus_input);
            this.Controls.Add(this.plus_input);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.div_label2);
            this.Controls.Add(this.div_label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mul_label2);
            this.Controls.Add(this.mul_label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minus_label2);
            this.Controls.Add(this.minus_label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.plus_label2);
            this.Controls.Add(this.plus_label1);
            this.Controls.Add(this.time_left_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.plus_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mul_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.div_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time_left_label;
        private System.Windows.Forms.Label plus_label1;
        private System.Windows.Forms.Label plus_label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label minus_label2;
        private System.Windows.Forms.Label minus_label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mul_label2;
        private System.Windows.Forms.Label mul_label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label div_label2;
        private System.Windows.Forms.Label div_label1;
        private System.Windows.Forms.NumericUpDown plus_input;
        private System.Windows.Forms.NumericUpDown minus_input;
        private System.Windows.Forms.NumericUpDown mul_input;
        private System.Windows.Forms.NumericUpDown div_input;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_button;
    }
}

