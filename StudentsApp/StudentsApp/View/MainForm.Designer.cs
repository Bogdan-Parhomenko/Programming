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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RecordNumberLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.FormOfEducationLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.RecordNumberTextBox = new System.Windows.Forms.TextBox();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.FormOfEducationTextBox = new System.Windows.Forms.TextBox();
            this.SelectedStudentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.Location = new System.Drawing.Point(13, 13);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(237, 368);
            this.StudentsListBox.TabIndex = 0;
            // 
            // SelectedStudentGroupBox
            // 
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
            this.SelectedStudentGroupBox.Size = new System.Drawing.Size(532, 211);
            this.SelectedStudentGroupBox.TabIndex = 1;
            this.SelectedStudentGroupBox.TabStop = false;
            this.SelectedStudentGroupBox.Text = "Selected Student";
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
            // RecordNumberLabel
            // 
            this.RecordNumberLabel.AutoSize = true;
            this.RecordNumberLabel.Location = new System.Drawing.Point(19, 48);
            this.RecordNumberLabel.Name = "RecordNumberLabel";
            this.RecordNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.RecordNumberLabel.TabIndex = 1;
            this.RecordNumberLabel.Text = "Record Number:";
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
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(60, 100);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(44, 13);
            this.FacultyLabel.TabIndex = 3;
            this.FacultyLabel.Text = "Faculty:";
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
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(110, 19);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(416, 20);
            this.FullNameTextBox.TabIndex = 5;
            // 
            // RecordNumberTextBox
            // 
            this.RecordNumberTextBox.Location = new System.Drawing.Point(110, 45);
            this.RecordNumberTextBox.Name = "RecordNumberTextBox";
            this.RecordNumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.RecordNumberTextBox.TabIndex = 6;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.Location = new System.Drawing.Point(110, 71);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(184, 20);
            this.GroupTextBox.TabIndex = 7;
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(110, 97);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(184, 20);
            this.FacultyTextBox.TabIndex = 8;
            // 
            // FormOfEducationTextBox
            // 
            this.FormOfEducationTextBox.Location = new System.Drawing.Point(110, 123);
            this.FormOfEducationTextBox.Name = "FormOfEducationTextBox";
            this.FormOfEducationTextBox.Size = new System.Drawing.Size(184, 20);
            this.FormOfEducationTextBox.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectedStudentGroupBox);
            this.Controls.Add(this.StudentsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "StudentsApp";
            this.SelectedStudentGroupBox.ResumeLayout(false);
            this.SelectedStudentGroupBox.PerformLayout();
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
    }
}

