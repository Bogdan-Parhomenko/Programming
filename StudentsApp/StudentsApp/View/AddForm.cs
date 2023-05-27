using System.Windows.Forms;
using System;
using StudentsApp.Model.Classes;
using System.Drawing;
using StudentsApp.Model.Enums;

namespace StudentsApp.View
{
    /// <summary>
    /// Содержит логику формы добавления студентов.
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Добавляемый студент.
        /// </summary>
        private Student _currentStudent = new Student();

        /// <summary>
        /// Возвращает и задает добавляемого студента.
        /// </summary>
        public Student AddStudent { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="AddForm"/>.
        /// Заполняет ComboBox перечислениями и RecordNumberTextBox номером зачетки создаваемого студента.
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            FacultyComboBox.Items.AddRange(Enum.GetNames(typeof(Faculty)));
            FormOfEducationComboBox.Items.AddRange(Enum.GetNames(typeof(FormOfEducation)));
            RecordNumberTextBox.Text = _currentStudent.RecordNumber.ToString();
        }

        /// <summary>
        /// При изменении текста FullNameTextBox пытается присвоить этот текст в свойство FullName элемента
        /// _currentStudent и красит FullNameTextBox в соответствии с валидацией.
        /// </summary>
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

        /// <summary>
        /// При изменении текста GroupTextBox пытается присвоить этот текст в свойство Group элемента
        /// _currentStudent и красит GroupTextBox в соответствии с валидацией.
        /// </summary>
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

        /// <summary>
        /// При выборе нового значения FacultyComboBox присваивает его в свойство Faculty элемента _currentStudent.
        /// </summary>
        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.Faculty = FacultyComboBox.Text;
        }

        /// <summary>
        /// При выборе нового значения FormOfEducationComboBox присваивает его в свойство FormOfEducation элемента _currentStudent.
        /// </summary>
        private void FormOfEducationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentStudent.FormOfEducation = FormOfEducationComboBox.Text;
        }

        /// <summary>
        /// При нажатии на кнопку добавления студента, если все поля экземпляра студента не пустые,
        /// то передает его в свойство AddStudent и закрывает форму.
        /// </summary>
        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            if (_currentStudent.FullName == null || _currentStudent.Group == null ||
                _currentStudent.Faculty == null || _currentStudent.FormOfEducation == null)
            {
                return;
            }
            if (FullNameTextBox.Text.Length > 200 || GroupTextBox.Text.Length > 10)
            {
                return;
            }
            AddStudent = _currentStudent;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// При нажатии на кнопку удаления студента удаляет студента и закрывает форму.
        /// </summary>
        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
