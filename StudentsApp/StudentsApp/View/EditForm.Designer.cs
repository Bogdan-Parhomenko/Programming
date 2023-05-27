namespace StudentsApp.View
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.EditingStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.StudentsDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.FormOfEducationComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsEditPictureBox = new System.Windows.Forms.PictureBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FormOfEducationLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.EditingStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsEditPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditingStudentGroupBox
            // 
            this.EditingStudentGroupBox.Controls.Add(this.StudentsDeletePictureBox);
            this.EditingStudentGroupBox.Controls.Add(this.FormOfEducationComboBox);
            this.EditingStudentGroupBox.Controls.Add(this.StudentsEditPictureBox);
            this.EditingStudentGroupBox.Controls.Add(this.FacultyComboBox);
            this.EditingStudentGroupBox.Controls.Add(this.GroupTextBox);
            this.EditingStudentGroupBox.Controls.Add(this.RecordNumberTextBox);
            this.EditingStudentGroupBox.Controls.Add(this.FullNameTextBox);
            this.EditingStudentGroupBox.Controls.Add(this.FormOfEducationLabel);
            this.EditingStudentGroupBox.Controls.Add(this.FacultyLabel);
            this.EditingStudentGroupBox.Controls.Add(this.GroupLabel);
            this.EditingStudentGroupBox.Controls.Add(this.RecordNumberLabel);
            this.EditingStudentGroupBox.Controls.Add(this.FullNameLabel);
            this.EditingStudentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditingStudentGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EditingStudentGroupBox.Name = "EditingStudentGroupBox";
            this.EditingStudentGroupBox.Size = new System.Drawing.Size(539, 220);
            this.EditingStudentGroupBox.TabIndex = 2;
            this.EditingStudentGroupBox.TabStop = false;
            this.EditingStudentGroupBox.Text = "Edit Student";
            // 
            // StudentsDeletePictureBox
            // 
            this.StudentsDeletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsDeletePictureBox.Image = global::StudentsApp.Properties.Resources.studentsDelete_50x50;
            this.StudentsDeletePictureBox.Location = new System.Drawing.Point(421, 158);
            this.StudentsDeletePictureBox.Name = "StudentsDeletePictureBox";
            this.StudentsDeletePictureBox.Size = new System.Drawing.Size(50, 50);
            this.StudentsDeletePictureBox.TabIndex = 12;
            this.StudentsDeletePictureBox.TabStop = false;
            this.StudentsDeletePictureBox.Click += new System.EventHandler(this.StudentsDeletePictureBox_Click);
            // 
            // FormOfEducationComboBox
            // 
            this.FormOfEducationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormOfEducationComboBox.FormattingEnabled = true;
            this.FormOfEducationComboBox.Location = new System.Drawing.Point(110, 124);
            this.FormOfEducationComboBox.Name = "FormOfEducationComboBox";
            this.FormOfEducationComboBox.Size = new System.Drawing.Size(184, 21);
            this.FormOfEducationComboBox.TabIndex = 9;
            this.FormOfEducationComboBox.SelectedIndexChanged += new System.EventHandler(this.FormOfEducationComboBox_SelectedIndexChanged);
            // 
            // StudentsEditPictureBox
            // 
            this.StudentsEditPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentsEditPictureBox.Image = global::StudentsApp.Properties.Resources.studentsAdd_50x50;
            this.StudentsEditPictureBox.Location = new System.Drawing.Point(477, 158);
            this.StudentsEditPictureBox.Name = "StudentsEditPictureBox";
            this.StudentsEditPictureBox.Size = new System.Drawing.Size(50, 50);
            this.StudentsEditPictureBox.TabIndex = 11;
            this.StudentsEditPictureBox.TabStop = false;
            this.StudentsEditPictureBox.Click += new System.EventHandler(this.StudentsEditPictureBox_Click);
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(110, 97);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(184, 21);
            this.FacultyComboBox.TabIndex = 8;
            this.FacultyComboBox.SelectedIndexChanged += new System.EventHandler(this.FacultyComboBox_SelectedIndexChanged);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(110, 71);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(184, 20);
            this.GroupTextBox.TabIndex = 7;
            this.GroupTextBox.TextChanged += new System.EventHandler(this.GroupTextBox_TextChanged);
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.Location = new System.Drawing.Point(110, 45);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
            this.RecordNumberTextBox.ReadOnly = true;
            this.RecordNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.RecordNumberTextBox.TabIndex = 6;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(416, 20);
            this.FullNameTextBox.TabIndex = 5;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FormOfEducationLabel
            // 
            this.FormOfEducationLabel.AutoSize = true;
            this.FormOfEducationLabel.Location = new System.Drawing.Point(8, 127);
            this.FormOfEducationLabel.Name = "FormOfEducationLabel";
            this.FormOfEducationLabel.Size = new System.Drawing.Size(96, 13);
            this.FormOfEducationLabel.TabIndex = 4;
            this.FormOfEducationLabel.Text = "Form of Education:";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(60, 100);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(44, 13);
            this.FacultyLabel.TabIndex = 3;
            this.FacultyLabel.Text = "Faculty:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(65, 74);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(39, 13);
            this.GroupLabel.TabIndex = 2;
            this.GroupLabel.Text = "Group:";
            // 
            // RecordNumberLabel
            // 
            this.RecordNumberLabel.AutoSize = true;
            this.RecordNumberLabel.Location = new System.Drawing.Point(19, 48);
            this.RecordNumberLabel.Name = "RecordNumberLabel";
            this.RecordNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.RecordNumberLabel.TabIndex = 1;
            this.RecordNumberLabel.Text = "Record Number:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(47, 22);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 220);
            this.Controls.Add(this.EditingStudentGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Editing";
            this.EditingStudentGroupBox.ResumeLayout(false);
            this.EditingStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsEditPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EditingStudentGroupBox;
        private System.Windows.Forms.ComboBox FormOfEducationComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FormOfEducationLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label RecordNumberLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox StudentsDeletePictureBox;
        private System.Windows.Forms.PictureBox StudentsEditPictureBox;
    }
}