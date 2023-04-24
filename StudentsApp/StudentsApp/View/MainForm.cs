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

        private bool isEditButtonPressed = false;

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            StudentsListBox.DisplayMember = nameof(Student.Info);
        }

        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Items.Clear();
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Items.Clear();
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        private void ClearStudentsInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            RecordNumberTextBox.Clear();
            GroupTextBox.Clear();
            GroupTextBox.BackColor = Color.White;
            FacultyComboBox.Items.Clear();
            FormOfEducationComboBox.Items.Clear();
        }

        private void UpdateListBoxInfo()
        {
            StudentsListBox.SelectedIndexChanged -= StudentsListBox_SelectedIndexChanged;
            StudentsListBox.Items[StudentsListBox.SelectedIndex] = _students[StudentsListBox.SelectedIndex];
            StudentsListBox.SelectedIndexChanged += StudentsListBox_SelectedIndexChanged;
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
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            if (isEditButtonPressed)
            {
                FullNameTextBox.Enabled = false;
                RecordNumberTextBox.Enabled = false;
                GroupTextBox.Enabled = false;
                FacultyComboBox.Enabled = false;
                FormOfEducationComboBox.Enabled = false;
                isEditButtonPressed = false;
            }
            else
            {
                FullNameTextBox.Enabled = true;
                RecordNumberTextBox.Enabled = true;
                GroupTextBox.Enabled = true;
                FacultyComboBox.Enabled = true;
                FormOfEducationComboBox.Enabled = true;
                isEditButtonPressed = true;
            }

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FullNameTextBox.Text == "")
                {
                    return;
                }
                FullNameTextBox.BackColor = Color.White;
                _currentStudent.FullName = FullNameTextBox.Text;
                UpdateListBoxInfo();
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
                if (GroupTextBox.Text == "")
                {
                    return;
                }
                GroupTextBox.BackColor = Color.White;
                _currentStudent.Group = GroupTextBox.Text;
                UpdateListBoxInfo();
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.Faculty = FacultyComboBox.Text;
            UpdateListBoxInfo();
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }
    }
}