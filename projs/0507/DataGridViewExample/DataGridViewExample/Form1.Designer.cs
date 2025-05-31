namespace DataGridViewExample
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
            this.grid_col_create_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pid_show_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.col1_text_box = new System.Windows.Forms.TextBox();
            this.col2_text_box = new System.Windows.Forms.TextBox();
            this.col3_text_box = new System.Windows.Forms.TextBox();
            this.data_add_button = new System.Windows.Forms.Button();
            this.col4_text_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_col_create_button
            // 
            this.grid_col_create_button.Location = new System.Drawing.Point(12, 24);
            this.grid_col_create_button.Name = "grid_col_create_button";
            this.grid_col_create_button.Size = new System.Drawing.Size(105, 74);
            this.grid_col_create_button.TabIndex = 0;
            this.grid_col_create_button.Text = "그리드 열생성";
            this.grid_col_create_button.UseVisualStyleBackColor = true;
            this.grid_col_create_button.Click += new System.EventHandler(this.grid_col_create_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pid_show_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delete_button);
            this.groupBox1.Controls.Add(this.edit_button);
            this.groupBox1.Controls.Add(this.copy_button);
            this.groupBox1.Controls.Add(this.col1_text_box);
            this.groupBox1.Controls.Add(this.col2_text_box);
            this.groupBox1.Controls.Add(this.col3_text_box);
            this.groupBox1.Controls.Add(this.data_add_button);
            this.groupBox1.Controls.Add(this.col4_text_box);
            this.groupBox1.Location = new System.Drawing.Point(134, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "데이터 관리";
            // 
            // pid_show_label
            // 
            this.pid_show_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pid_show_label.Location = new System.Drawing.Point(206, 50);
            this.pid_show_label.Name = "pid_show_label";
            this.pid_show_label.Size = new System.Drawing.Size(558, 30);
            this.pid_show_label.TabIndex = 14;
            this.pid_show_label.Text = "PID";
            this.pid_show_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(1025, 114);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(79, 35);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "삭제";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(940, 114);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(79, 35);
            this.edit_button.TabIndex = 7;
            this.edit_button.Text = "수정";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(855, 114);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(79, 35);
            this.copy_button.TabIndex = 6;
            this.copy_button.Text = "복사";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // col1_text_box
            // 
            this.col1_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.col1_text_box.Location = new System.Drawing.Point(18, 114);
            this.col1_text_box.Name = "col1_text_box";
            this.col1_text_box.Size = new System.Drawing.Size(182, 32);
            this.col1_text_box.TabIndex = 1;
            // 
            // col2_text_box
            // 
            this.col2_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.col2_text_box.Location = new System.Drawing.Point(206, 114);
            this.col2_text_box.Name = "col2_text_box";
            this.col2_text_box.Size = new System.Drawing.Size(182, 32);
            this.col2_text_box.TabIndex = 2;
            // 
            // col3_text_box
            // 
            this.col3_text_box.AcceptsReturn = true;
            this.col3_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.col3_text_box.Location = new System.Drawing.Point(394, 114);
            this.col3_text_box.Name = "col3_text_box";
            this.col3_text_box.Size = new System.Drawing.Size(182, 32);
            this.col3_text_box.TabIndex = 3;
            // 
            // data_add_button
            // 
            this.data_add_button.Location = new System.Drawing.Point(770, 111);
            this.data_add_button.Name = "data_add_button";
            this.data_add_button.Size = new System.Drawing.Size(79, 35);
            this.data_add_button.TabIndex = 5;
            this.data_add_button.Text = "추가";
            this.data_add_button.UseVisualStyleBackColor = true;
            this.data_add_button.Click += new System.EventHandler(this.data_add_button_Click);
            // 
            // col4_text_box
            // 
            this.col4_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.col4_text_box.Location = new System.Drawing.Point(582, 114);
            this.col4_text_box.Name = "col4_text_box";
            this.col4_text_box.Size = new System.Drawing.Size(182, 32);
            this.col4_text_box.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 572);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복사ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.복사ToolStripMenuItem.Text = "복사";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.복사ToolStripMenuItem_Click);
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.삭제ToolStripMenuItem.Text = "삭제";
            this.삭제ToolStripMenuItem.Click += new System.EventHandler(this.삭제ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 832);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_col_create_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button grid_col_create_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button data_add_button;
        private System.Windows.Forms.TextBox col4_text_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox col1_text_box;
        private System.Windows.Forms.TextBox col2_text_box;
        private System.Windows.Forms.TextBox col3_text_box;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pid_show_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}

