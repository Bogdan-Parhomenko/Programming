using StudentsApp.Model.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace StudentsApp.View
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список элементов класса Student.
        /// </summary>
        private BindingList<Student> _students = new BindingList<Student>();

        /// <summary>
        /// Относительный путь к папке, где должен лежать файл json.
        /// </summary>
        private string _pathToJson = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp";

        /// <summary>
        /// Относительный путь к файлу json.
        /// </summary>
        private string _jsonPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp\\students.json";

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// Если не существует файла json и папки, где он должен лежать, то создаем их.
        /// Загружаем всех ранее созданных экземпляров класса Student и заполняет их данными StudentsListBox.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
            JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                Student tempStudent = serializer.Deserialize<Student>(reader);
                _students.Add(tempStudent);
            }
            reader.Close();
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
        }

        /// <summary>
        /// Сортирует экземпляры класса Student по алфавиту по полному имени.
        /// </summary>
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

        /// <summary>
        /// Обновляет текстовые поля выбранного студента.
        /// </summary>
        /// <param name="student">Студент, текстовые поля которого необходимо обновить.</param>
        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
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

        /// <summary>
        /// При изменении выбранного элемента StudentsListBox
        /// заполняет все текстовые поля значениями выбранного _student.
        /// Если студент не выбран, то очищает все текстовые поля.
        /// </summary>
        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        /// <summary>
        /// При нажатии на кнопку добавления студента открывает соответствующую форму
        /// и добавляет созданного студента в список _students.
        /// Сортирует список студентов и записывает нового студента в файл json.
        /// </summary>
        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Student());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _students.Add(editForm.CurrentStudent);
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _students.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
            }
        }

        /// <summary>
        /// При нажатии на кнопку удаления студента удаляет выбранного студента из списка и из StudentsListBox.
        /// Также удаляет выбранного студента из файла json.
        /// </summary>
        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _students.RemoveAt(selectedIndex);
                StudentsListBox.SelectedIndex = -1;
                File.WriteAllText(_jsonPath, string.Empty);
                for (int i = 0; i < _students.Count; i++)
                {
                    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
                }
            }
        }

        /// <summary>
        /// При нажатии на кнопку изменения студента открывает соответствующую форму
        /// и изменяет студента в списке _students.
        /// Сортирует список студентов и записывает измененного студента в файл json.
        /// </summary>
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditForm editForm = new EditForm(_students[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _students[selectedIndex] = editForm.CurrentStudent;
                }
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _students.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
            }
        }
    }
}