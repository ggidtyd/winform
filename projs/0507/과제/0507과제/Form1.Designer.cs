namespace _0507과제
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.reg_button = new System.Windows.Forms.Button();
            this.gpa_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address_text_box = new System.Windows.Forms.TextBox();
            this.phone_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.show_button);
            this.groupBox1.Controls.Add(this.del_button);
            this.groupBox1.Controls.Add(this.edit_button);
            this.groupBox1.Controls.Add(this.reg_button);
            this.groupBox1.Controls.Add(this.gpa_text_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.address_text_box);
            this.groupBox1.Controls.Add(this.phone_text_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name_text_box);
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1416, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생 정보 관리";
            // 
            // show_button
            // 
            this.show_button.Location = new System.Drawing.Point(1321, 79);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(75, 49);
            this.show_button.TabIndex = 13;
            this.show_button.Text = "조회";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(1240, 79);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 49);
            this.del_button.TabIndex = 12;
            this.del_button.Text = "삭제";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(1159, 79);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 49);
            this.edit_button.TabIndex = 11;
            this.edit_button.Text = "수정";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // reg_button
            // 
            this.reg_button.Location = new System.Drawing.Point(1078, 79);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(75, 49);
            this.reg_button.TabIndex = 1;
            this.reg_button.Text = "등록";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // gpa_text_box
            // 
            this.gpa_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpa_text_box.Location = new System.Drawing.Point(946, 87);
            this.gpa_text_box.Name = "gpa_text_box";
            this.gpa_text_box.Size = new System.Drawing.Size(126, 32);
            this.gpa_text_box.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(942, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "학점";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "주소";
            // 
            // address_text_box
            // 
            this.address_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_text_box.Location = new System.Drawing.Point(619, 87);
            this.address_text_box.Name = "address_text_box";
            this.address_text_box.Size = new System.Drawing.Size(321, 32);
            this.address_text_box.TabIndex = 7;
            // 
            // phone_text_box
            // 
            this.phone_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_text_box.Location = new System.Drawing.Point(392, 87);
            this.phone_text_box.Name = "phone_text_box";
            this.phone_text_box.Size = new System.Drawing.Size(221, 32);
            this.phone_text_box.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "전화번호";
            // 
            // name_text_box
            // 
            this.name_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_text_box.Location = new System.Drawing.Point(204, 87);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(182, 32);
            this.name_text_box.TabIndex = 4;
            // 
            // id_text_box
            // 
            this.id_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_text_box.Location = new System.Drawing.Point(16, 87);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(182, 32);
            this.id_text_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "학번";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(39, 196);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 34;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1416, 616);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수정ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // 수정ToolStripMenuItem
            // 
            this.수정ToolStripMenuItem.Name = "수정ToolStripMenuItem";
            this.수정ToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.수정ToolStripMenuItem.Text = "수정";
            this.수정ToolStripMenuItem.Click += new System.EventHandler(this.수정ToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(1493, 834);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.TextBox gpa_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_text_box;
        private System.Windows.Forms.TextBox phone_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.TextBox id_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    }
}

