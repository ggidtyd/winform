namespace midterm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea25 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend25 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea26 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend26 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea27 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend27 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend28 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.v_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.point_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_numericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.point_numericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.v_numericUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stop_button);
            this.panel1.Controls.Add(this.start_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 100);
            this.panel1.TabIndex = 0;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(26, 22);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(125, 52);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(157, 22);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(125, 52);
            this.stop_button.TabIndex = 1;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "속도";
            // 
            // v_numericUpDown
            // 
            this.v_numericUpDown.Location = new System.Drawing.Point(383, 36);
            this.v_numericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.v_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.v_numericUpDown.Name = "v_numericUpDown";
            this.v_numericUpDown.Size = new System.Drawing.Size(120, 32);
            this.v_numericUpDown.TabIndex = 3;
            this.v_numericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.v_numericUpDown.ValueChanged += new System.EventHandler(this.v_numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Point 개수";
            // 
            // point_numericUpDown
            // 
            this.point_numericUpDown.Location = new System.Drawing.Point(648, 36);
            this.point_numericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.point_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.point_numericUpDown.Name = "point_numericUpDown";
            this.point_numericUpDown.Size = new System.Drawing.Size(120, 32);
            this.point_numericUpDown.TabIndex = 5;
            this.point_numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.point_numericUpDown.ValueChanged += new System.EventHandler(this.point_numericUpDown_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1541, 907);
            this.panel2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chart4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1541, 907);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea25.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea25);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend25.Name = "Legend1";
            this.chart1.Legends.Add(legend25);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(764, 447);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea26.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea26);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend26.Name = "Legend1";
            this.chart2.Legends.Add(legend26);
            this.chart2.Location = new System.Drawing.Point(773, 3);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(765, 447);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea27.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea27);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend27.Name = "Legend1";
            this.chart3.Legends.Add(legend27);
            this.chart3.Location = new System.Drawing.Point(3, 456);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(764, 448);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea28.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea28);
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend28.Name = "Legend1";
            this.chart4.Legends.Add(legend28);
            this.chart4.Location = new System.Drawing.Point(773, 456);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(765, 448);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 1007);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point_numericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown point_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown v_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Timer timer1;
    }
}

