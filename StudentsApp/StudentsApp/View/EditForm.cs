using StudentsApp.Model.Classes;
using StudentsApp.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentsApp.View
{
    public partial class EditForm : Form
    {
        private Student _copiedStudent = new Student();

        public Student EditStudent { get; set; }

        public EditForm(Student student)
        {
            InitializeComponent();
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
            _copiedStudent = Student.CopyStudent(student);
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _copiedStudent.FullName = FullNameTextBox.Text;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GroupTextBox.BackColor = Color.White;
                _copiedStudent.Group = GroupTextBox.Text;
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _copiedStudent.Faculty = FacultyComboBox.Text;
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _copiedStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }

        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            if (_copiedStudent.FullName == null || _copiedStudent.Group == null ||
                _copiedStudent.Faculty == null || _copiedStudent.FormOfEducation == null)
            {
                return;
            }
            EditStudent = _copiedStudent;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
