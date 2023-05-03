using StudentsApp.Model.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace StudentsApp.View
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        private BindingList<Student> _students = new BindingList<Student>();

        private Student _currentStudent = new Student();

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
        }

        private void StudentsSort(Student student)
        {
            int selectedStudent;
            for (var i = 0; i < _students.Count; i++)
            {
                if (student == _students[i])
                {
                    continue;
                }
                if (isNeedToExchange(student, _students[i]))
                {
                    selectedStudent = StudentsListBox.SelectedIndex;
                    _students.RemoveAt(selectedStudent);
                    _students.Insert(i, student);
                    StudentsListBox.SelectedIndex = i;
                }
            }
        }

        private bool isNeedToExchange(Student movableStudent, Student anotherStudent)
        {
            if (movableStudent.FullName == null)
            {
                return true;
            }
            var movableCharName = movableStudent.FullName.ToCharArray();
            if (anotherStudent.FullName == null)
            {
                return true;
            }
            var anotherCharName = anotherStudent.FullName.ToCharArray();

            for (var i = 0; i < Math.Min(movableCharName.Length, anotherCharName.Length); i++)
            {
                if (movableCharName[i] < anotherCharName[i])
                {
                    return true;
                }
                else if (movableCharName[i] > anotherCharName[i])
                {
                    return false;
                }
            }
            if (movableCharName.Length < anotherCharName.Length)
            {
                return true;
            }
            else if (movableCharName.Length > anotherCharName.Length)
            {
                return false;
            }
            return false;
        }

        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        private void ClearStudentsInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            RecordNumberTextBox.Clear();
            GroupTextBox.Clear();
            GroupTextBox.BackColor = Color.White;
            FacultyComboBox.Text = "";
            FormOfEducationComboBox.Text = "";
        }

        private void UpdateListBoxInfo()
        {
            StudentsListBox.SelectedIndexChanged -= StudentsListBox_SelectedIndexChanged;
            StudentsListBox.DataSource = null;
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
            StudentsListBox.SelectedIndexChanged += StudentsListBox_SelectedIndexChanged;
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (StudentsListBox.SelectedIndex != -1)
            {
                UpdateStudentsInfo(_students[StudentsListBox.SelectedIndex]);
                 
            }
            else
            {
                ClearStudentsInfo();
            }
        }

        private void StudentsAddPictureBox_Click(object sender, System.EventArgs e)
        {
            AddForm _addForm = new AddForm();
            _addForm.ShowDialog();
            _students.Add(_addForm.AddStudent);
            StudentsListBox.SelectedIndex = -1;
        }

        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _students.RemoveAt(selectedIndex);
                StudentsListBox.SelectedIndex = -1;
            }
        }
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1)
            {
                return;
            }
            EditForm _editForm = new EditForm();
            _editForm.ShowDialog(); 
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FullNameTextBox.Text == "")
                {
                    return;
                }
                if (StudentsListBox.SelectedIndex == -1)
                {
                    return;
                }
                FullNameTextBox.BackColor = Color.White;
                _currentStudent.FullName = FullNameTextBox.Text;
                //UpdateListBoxInfo();
                //StudentsSort(_currentStudent);
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
                if (StudentsListBox.SelectedIndex == -1)
                {
                    return;
                }
                GroupTextBox.BackColor = Color.White;
                _currentStudent.Group = GroupTextBox.Text;
                //UpdateListBoxInfo();
            }
            catch
            {
                GroupTextBox.BackColor = Color.LightPink;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentStudent.Faculty = FacultyComboBox.Text;
            //UpdateListBoxInfo();
        }

        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }
    }
}