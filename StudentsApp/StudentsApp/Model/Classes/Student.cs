using System;
using System.Runtime.CompilerServices;

namespace StudentsApp.Model.Classes
{
    /// <summary>
    /// Хранит данные о студенте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Полное имя студента.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Начало отсчета номера зачетной книжки.
        /// </summary>
        private static int _studentsFirstNumber = 99999;

        /// <summary>
        /// Группа студента.
        /// </summary>
        private string _group;

        /// <summary>
        /// Возвращает и задает полное имя студента. Должно содержать менее 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                CheckStringLength(value, 200);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает номер зачетной книжки студента. Должен состоять из 6 цифр.
        /// </summary>
        public static int StudentsFirstNumber
        {
            get => _studentsFirstNumber;
            private set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentException("Номер зачетки должен состоять из 6 цифр.");
                }
                _studentsFirstNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает уникальный номер зачетной книжки студента.
        /// </summary>
        public int RecordNumber { get; set; }

        /// <summary>
        /// Возвращает или задает группу студента. Должна содержать менее 10 символов.
        /// </summary>
        public string Group
        {
            get => _group;
            set
            {
                CheckStringLength(value, 10);
                _group = value;
            }
        }

        /// <summary>
        /// Возвращает или задает факультет студента.
        /// </summary>
        public string Faculty { get; set; }

        /// <summary>
        /// Возвращает или задает форму обучения студента.
        /// </summary>
        public string FormOfEducation { get; set; }

        /// <summary>
        /// Возвращает строку, отражающую информацию о студенте.
        /// </summary>
        public string Info
        {
            get
            {
                return $"{FullName} - {Group} / {Faculty}";
            }
        }

        /// <summary>
        /// Копирует информацию о студенте.
        /// </summary>
        /// <param name="student">Искомый студент, чьи данные необходимо скопировать.</param>
        /// <returns>Возвращает студента со скопированной информацией.</returns>
        public static Student CopyStudent(Student student)
        {
            Student copiedStudent = new Student();
            copiedStudent.FullName = student.FullName;
            copiedStudent.Group = student.Group;
            copiedStudent.Faculty = student.Faculty;
            copiedStudent.FormOfEducation = student.FormOfEducation;
            copiedStudent.RecordNumber = student.RecordNumber;
            return copiedStudent;
        }

        /// <summary>
        /// Проверяет, что искомая строка короче заданной максимальной длинны.
        /// </summary>
        /// <param name="value">Искомая строка.</param>
        /// <param name="maxLength">Максимально возможная длинна.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если вводимая строка длиннее максимальной длинны.</exception>
        private static void CheckStringLength(string value, int maxLength, [CallerMemberName] string propertyName = "")
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} не может содержать больше {maxLength} символов.");
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Student"/> без его инициализации.
        /// </summary>
        public Student()
        {
            StudentsFirstNumber++;
            RecordNumber = StudentsFirstNumber;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Student"/>.
        /// </summary>
        /// <param name="fullName">Полное имя студента. Должно содержать менее 200 символов.</param>
        /// <param name="group">Группа студента. Должна содержать менее 10 символов.</param>
        /// <param name="faculty">Факультет студента.</param>
        /// <param name="formOfEducation">Форма обучения студента.</param>
        public Student(string fullName, string group, string faculty, string formOfEducation)
        {
            FullName = fullName;
            StudentsFirstNumber++;
            RecordNumber = StudentsFirstNumber;
            Group = group;
            Faculty = faculty;
            FormOfEducation = formOfEducation;
        }
    }
}
