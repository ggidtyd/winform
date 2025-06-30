namespace DB01
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh_button = new System.Windows.Forms.Button();
            this.add_user_button = new System.Windows.Forms.Button();
            this.modify_user_button = new System.Windows.Forms.Button();
            this.delete_user_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "쇼핑몰 사용자 관리";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(201, 26);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(158, 50);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "프로그램 종료";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1336, 658);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1328, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사용자 관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete_user_button);
            this.panel2.Controls.Add(this.modify_user_button);
            this.panel2.Controls.Add(this.add_user_button);
            this.panel2.Controls.Add(this.refresh_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1322, 80);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 537);
            this.dataGridView1.TabIndex = 1;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(3, 16);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(137, 44);
            this.refresh_button.TabIndex = 2;
            this.refresh_button.Text = "새로고침";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // add_user_button
            // 
            this.add_user_button.Location = new System.Drawing.Point(146, 16);
            this.add_user_button.Name = "add_user_button";
            this.add_user_button.Size = new System.Drawing.Size(137, 44);
            this.add_user_button.TabIndex = 3;
            this.add_user_button.Text = "사용자 추가";
            this.add_user_button.UseVisualStyleBackColor = true;
            this.add_user_button.Click += new System.EventHandler(this.add_user_button_Click);
            // 
            // modify_user_button
            // 
            this.modify_user_button.Location = new System.Drawing.Point(289, 16);
            this.modify_user_button.Name = "modify_user_button";
            this.modify_user_button.Size = new System.Drawing.Size(137, 44);
            this.modify_user_button.TabIndex = 4;
            this.modify_user_button.Text = "사용자 수정";
            this.modify_user_button.UseVisualStyleBackColor = true;
            // 
            // delete_user_button
            // 
            this.delete_user_button.Location = new System.Drawing.Point(432, 16);
            this.delete_user_button.Name = "delete_user_button";
            this.delete_user_button.Size = new System.Drawing.Size(137, 44);
            this.delete_user_button.TabIndex = 5;
            this.delete_user_button.Text = "사용자 삭제";
            this.delete_user_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 766);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete_user_button;
        private System.Windows.Forms.Button modify_user_button;
        private System.Windows.Forms.Button add_user_button;
        private System.Windows.Forms.Button refresh_button;
    }
}

