using System.Windows.Forms;
using System;
using StudentsApp.Model.Classes;
using System.Drawing;
using StudentsApp.Model.Enums;

namespace StudentsApp.View
{
    public partial class AddForm : Form
    {
        private Student _currentStudent = new Student();

        public Student AddStudent { get; set; }

        public AddForm()
        {
            InitializeComponent();
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            RecordNumberTextBox.Text = _currentStudent.RecordNumber.ToString();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _currentStudent.FullName = FullNameTextBox.Text;
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
                _currentStudent.Group = GroupTextBox.Text;
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.Faculty = FacultyComboBox.Text;
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }

        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            if (_currentStudent.FullName == null || _currentStudent.Group == null ||
                _currentStudent.Faculty == null || _currentStudent.FormOfEducation == null)
            {
                return;
            }
            AddStudent = _currentStudent;
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
