namespace StudentsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.SelectedStudentGroupBox = new System.Windows.Forms.GroupBox();
            this.FormOfEducationTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FormOfEducationLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.StudentsAddPictureBox = new System.Windows.Forms.PictureBox();
            this.StudentsEditPictureBox = new System.Windows.Forms.PictureBox();
            this.StudentsDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedStudentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsEditPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDeletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.IntegralHeight = false;
            this.StudentsListBox.Location = new System.Drawing.Point(13, 13);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(237, 368);
            this.StudentsListBox.TabIndex = 17;
            // 
            // SelectedStudentGroupBox
            // 
            this.SelectedStudentGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedStudentGroupBox.Controls.Add(this.FormOfEducationTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.RecordNumberTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameTextBox);
            this.SelectedStudentGroupBox.Controls.Add(this.FormOfEducationLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FacultyLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.GroupLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.RecordNumberLabel);
            this.SelectedStudentGroupBox.Controls.Add(this.FullNameLabel);
            this.SelectedStudentGroupBox.Location = new System.Drawing.Point(256, 13);
            this.SelectedStudentGroupBox.Name = "SelectedStudentGroupBox";
            this.SelectedStudentGroupBox.Size = new System.Drawing.Size(532, 152);
            this.SelectedStudentGroupBox.TabIndex = 1;
            this.SelectedStudentGroupBox.TabStop = false;
            this.SelectedStudentGroupBox.Text = "Selected Student";
            // 
            // FormOfEducationTextBox
            // 
            this.FormOfEducationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormOfEducationTextBox.Location = new System.Drawing.Point(110, 123);
            this.FormOfEducationTextBox.Name = "FormOfEducationTextBox";
            this.FormOfEducationTextBox.Size = new System.Drawing.Size(184, 20);
            this.FormOfEducationTextBox.TabIndex = 9;
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacultyTextBox.Location = new System.Drawing.Point(110, 97);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(184, 20);
            this.FacultyTextBox.TabIndex = 8;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupTextBox.Location = new System.Drawing.Point(110, 71);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(184, 20);
            this.GroupTextBox.TabIndex = 7;
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordNumberTextBox.Location = new System.Drawing.Point(110, 45);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
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
            // 
            // FormOfEducationLabel
            // 
            this.FormOfEducationLabel.AutoSize = true;
            this.FormOfEducationLabel.Location = new System.Drawing.Point(8, 126);
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
            // StudentsAddPictureBox
            // 
            this.StudentsAddPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentsAddPictureBox.Image = global::StudentsApp.Properties.Resources.studentsAdd_50x50;
            this.StudentsAddPictureBox.Location = new System.Drawing.Point(13, 388);
            this.StudentsAddPictureBox.Name = "StudentsAddPictureBox";
            this.StudentsAddPictureBox.Size = new System.Drawing.Size(50, 50);
            this.StudentsAddPictureBox.TabIndex = 2;
            this.StudentsAddPictureBox.TabStop = false;
            // 
            // StudentsEditPictureBox
            // 
            this.StudentsEditPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentsEditPictureBox.Image = global::StudentsApp.Properties.Resources.studentsEdit_50x50;
            this.StudentsEditPictureBox.Location = new System.Drawing.Point(106, 388);
            this.StudentsEditPictureBox.Name = "StudentsEditPictureBox";
            this.StudentsEditPictureBox.Size = new System.Drawing.Size(50, 50);
            this.StudentsEditPictureBox.TabIndex = 3;
            this.StudentsEditPictureBox.TabStop = false;
            // 
            // StudentsDeletePictureBox
            // 
            this.StudentsDeletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StudentsDeletePictureBox.Image = global::StudentsApp.Properties.Resources.studentsDelete_50x50;
            this.StudentsDeletePictureBox.Location = new System.Drawing.Point(200, 388);
            this.StudentsDeletePictureBox.Name = "StudentsDeletePictureBox";
            this.StudentsDeletePictureBox.Size = new System.Drawing.Size(50, 50);
            this.StudentsDeletePictureBox.TabIndex = 4;
            this.StudentsDeletePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentsDeletePictureBox);
            this.Controls.Add(this.StudentsEditPictureBox);
            this.Controls.Add(this.StudentsAddPictureBox);
            this.Controls.Add(this.SelectedStudentGroupBox);
            this.Controls.Add(this.StudentsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "StudentsApp";
            this.SelectedStudentGroupBox.ResumeLayout(false);
            this.SelectedStudentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsAddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsEditPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDeletePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.GroupBox SelectedStudentGroupBox;
        private System.Windows.Forms.TextBox FormOfEducationTextBox;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TextBox RecordNumberTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FormOfEducationLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label RecordNumberLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox StudentsAddPictureBox;
        private System.Windows.Forms.PictureBox StudentsEditPictureBox;
        private System.Windows.Forms.PictureBox StudentsDeletePictureBox;
    }
}

