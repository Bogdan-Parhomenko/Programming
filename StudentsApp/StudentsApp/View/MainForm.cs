using StudentsApp.Model.Classes;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using StudentsApp.Model.Enums;

namespace StudentsApp.View
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        private List<Student> _students = new List<Student>();

        private Student _currentStudent;

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            StudentsListBox.DisplayMember = nameof(Student.Info);

            //FacultyComboBox.DataSource = Enum.GetValues(typeof(Faculty));

            //FormOfEducationComboBox.DataSource = Enum.GetValues(typeof(FormOfEducation));
        }

        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Items.Clear();
            FacultyComboBox.Text = "";
            FormOfEducationComboBox.Items.Clear();
            FormOfEducationComboBox.Text = "";
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        private void ClearStudentsInfo()
        {
            FullNameTextBox.Clear();
            RecordNumberTextBox.Clear();
            GroupTextBox.Clear();
            FacultyComboBox.Items.Clear();
            FacultyComboBox.Text = "";
            FormOfEducationComboBox.Items.Clear();
            FormOfEducationComboBox.Text = "";
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (StudentsListBox.SelectedIndex != -1)
            {
                _currentStudent = _students[StudentsListBox.SelectedIndex];
                UpdateStudentsInfo( _currentStudent );
                 
            }
            else
            {
                ClearStudentsInfo();
            }
        }

        private void StudentsAddPictureBox_Click(object sender, System.EventArgs e)
        {
            var addedStudentId = _students.Count;
            _students.Add(new Student());
            StudentsListBox.Items.Add(_students[addedStudentId]);
        }

        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _students.RemoveAt(selectedIndex);
                StudentsListBox.Items.RemoveAt(selectedIndex);
            }
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

        private void FacultyComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FacultyComboBox.BackColor = Color.White;
                _currentStudent.Faculty = Enum.Parse(typeof(Faculty), FacultyComboBox.Text).ToString();
            }
            catch
            {
                FacultyComboBox.BackColor = Color.LightPink;
            }
        }

        private void FormOfEducationComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormOfEducationComboBox.BackColor = Color.White;
                _currentStudent.FormOfEducation = Enum.Parse(typeof(FormOfEducation), FormOfEducationComboBox.Text).ToString();
            }
            catch
            {
                FormOfEducationComboBox.BackColor = Color.LightPink;
            }
        }
    }
}