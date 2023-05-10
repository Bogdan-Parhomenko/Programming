using StudentsApp.Model.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace StudentsApp.View
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        private BindingList<Student> _students = new BindingList<Student>();

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
        }

        private void StudentsSort()
        {
            int size = _students.Count;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (String.Compare(_students.ElementAt(j).FullName, _students.ElementAt(j + 1).FullName) > 0)
                    {
                        Student temp = _students.ElementAt(j);
                        _students[j] = _students.ElementAt(j + 1);
                        _students[j + 1] = temp;
                    }
                }
            }
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
            if (_addForm.DialogResult == DialogResult.OK)
            {
                _students.Add(_addForm.AddStudent);
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
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
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditForm _editForm = new EditForm(_students[selectedIndex]);
                _editForm.ShowDialog();
                if (_editForm.DialogResult == DialogResult.OK)
                {
                    _students[selectedIndex] = _editForm.EditStudent;
                }
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
        }
    }
}