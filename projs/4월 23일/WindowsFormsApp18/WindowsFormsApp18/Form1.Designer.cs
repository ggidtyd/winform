namespace WindowsFormsApp18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.series_creation_button = new System.Windows.Forms.Button();
            this.random_value_add_button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // series_creation_button
            // 
            this.series_creation_button.Location = new System.Drawing.Point(36, 26);
            this.series_creation_button.Name = "series_creation_button";
            this.series_creation_button.Size = new System.Drawing.Size(130, 59);
            this.series_creation_button.TabIndex = 0;
            this.series_creation_button.Text = "Series 생성";
            this.series_creation_button.UseVisualStyleBackColor = true;
            this.series_creation_button.Click += new System.EventHandler(this.series_creation_button_Click);
            // 
            // random_value_add_button
            // 
            this.random_value_add_button.Location = new System.Drawing.Point(188, 26);
            this.random_value_add_button.Name = "random_value_add_button";
            this.random_value_add_button.Size = new System.Drawing.Size(172, 59);
            this.random_value_add_button.TabIndex = 1;
            this.random_value_add_button.Text = "Random 값 추가 ( 0 ~ 100 )";
            this.random_value_add_button.UseVisualStyleBackColor = true;
            this.random_value_add_button.Click += new System.EventHandler(this.random_value_add_button_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(36, 122);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1011, 623);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 768);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.random_value_add_button);
            this.Controls.Add(this.series_creation_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button series_creation_button;
        private System.Windows.Forms.Button random_value_add_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

