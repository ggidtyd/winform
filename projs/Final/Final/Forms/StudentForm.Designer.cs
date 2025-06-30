namespace Final.Forms
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnSave;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblStudentNumber.Location = new System.Drawing.Point(12, 15);
            this.lblStudentNumber.Text = "Student Number:";
            this.txtStudentNumber.Location = new System.Drawing.Point(120, 12);
            this.txtStudentNumber.Size = new System.Drawing.Size(150, 20);

            this.lblName.Location = new System.Drawing.Point(12, 45);
            this.lblName.Text = "Name:";
            this.txtName.Location = new System.Drawing.Point(120, 42);
            this.txtName.Size = new System.Drawing.Size(150, 20);

            this.lblPhone.Location = new System.Drawing.Point(12, 75);
            this.lblPhone.Text = "Phone:";
            this.txtPhone.Location = new System.Drawing.Point(120, 72);
            this.txtPhone.Size = new System.Drawing.Size(150, 20);

            this.btnSave.Location = new System.Drawing.Point(120, 110);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}