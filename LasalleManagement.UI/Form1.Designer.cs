namespace LasalleManagement.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddInternationalStudent = new System.Windows.Forms.Button();
            this.txtInternationalStudentEmail = new System.Windows.Forms.TextBox();
            this.txtInternationalStudentName = new System.Windows.Forms.TextBox();
            this.txtInternationalStudentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInternationalStudentHomeCountry = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStudentAdd);
            this.groupBox1.Controls.Add(this.txtStudentEmail);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.txtStudentId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(100, 53);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(281, 27);
            this.txtStudentId.TabIndex = 3;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(100, 86);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(281, 27);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(100, 119);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(281, 27);
            this.txtStudentEmail.TabIndex = 5;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.Location = new System.Drawing.Point(100, 166);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(281, 29);
            this.btnStudentAdd.TabIndex = 6;
            this.btnStudentAdd.Text = "Add";
            this.btnStudentAdd.UseVisualStyleBackColor = true;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInternationalStudentHomeCountry);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAddInternationalStudent);
            this.groupBox2.Controls.Add(this.txtInternationalStudentEmail);
            this.groupBox2.Controls.Add(this.txtInternationalStudentName);
            this.groupBox2.Controls.Add(this.txtInternationalStudentId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(542, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 236);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "International Student";
            // 
            // btnAddInternationalStudent
            // 
            this.btnAddInternationalStudent.Location = new System.Drawing.Point(100, 190);
            this.btnAddInternationalStudent.Name = "btnAddInternationalStudent";
            this.btnAddInternationalStudent.Size = new System.Drawing.Size(281, 29);
            this.btnAddInternationalStudent.TabIndex = 6;
            this.btnAddInternationalStudent.Text = "Add";
            this.btnAddInternationalStudent.UseVisualStyleBackColor = true;
            this.btnAddInternationalStudent.Click += new System.EventHandler(this.btnAddInternationalStudent_Click);
            // 
            // txtInternationalStudentEmail
            // 
            this.txtInternationalStudentEmail.Location = new System.Drawing.Point(100, 119);
            this.txtInternationalStudentEmail.Name = "txtInternationalStudentEmail";
            this.txtInternationalStudentEmail.Size = new System.Drawing.Size(281, 27);
            this.txtInternationalStudentEmail.TabIndex = 5;
            // 
            // txtInternationalStudentName
            // 
            this.txtInternationalStudentName.Location = new System.Drawing.Point(100, 86);
            this.txtInternationalStudentName.Name = "txtInternationalStudentName";
            this.txtInternationalStudentName.Size = new System.Drawing.Size(281, 27);
            this.txtInternationalStudentName.TabIndex = 4;
            // 
            // txtInternationalStudentId
            // 
            this.txtInternationalStudentId.Location = new System.Drawing.Point(100, 53);
            this.txtInternationalStudentId.Name = "txtInternationalStudentId";
            this.txtInternationalStudentId.Size = new System.Drawing.Size(281, 27);
            this.txtInternationalStudentId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Home Country:";
            // 
            // txtInternationalStudentHomeCountry
            // 
            this.txtInternationalStudentHomeCountry.Location = new System.Drawing.Point(156, 154);
            this.txtInternationalStudentHomeCountry.Name = "txtInternationalStudentHomeCountry";
            this.txtInternationalStudentHomeCountry.Size = new System.Drawing.Size(225, 27);
            this.txtInternationalStudentHomeCountry.TabIndex = 8;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(55, 301);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(901, 204);
            this.lstStudents.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 555);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnStudentAdd;
        private TextBox txtStudentEmail;
        private TextBox txtStudentName;
        private TextBox txtStudentId;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtInternationalStudentHomeCountry;
        private Label label7;
        private Button btnAddInternationalStudent;
        private TextBox txtInternationalStudentEmail;
        private TextBox txtInternationalStudentName;
        private TextBox txtInternationalStudentId;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox lstStudents;
    }
}