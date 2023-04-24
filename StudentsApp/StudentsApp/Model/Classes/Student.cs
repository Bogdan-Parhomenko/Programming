using System;
using System.Runtime.CompilerServices;

namespace StudentsApp.Model.Classes
{
    public class Student
    {
        private string _fullName;

        private static int _allStudentsCount = 100000;

        private string _group;

        public string FullName
        {
            get => _fullName;
            set
            {
                CheckStringLength(value, 200);
                _fullName = value;
            }
        }

        public static int AllStudentsCount
        {
            get => _allStudentsCount;
            private set
            {
                if (value.ToString().Length != 6)
                {
                    throw new ArgumentException("Номер зачетки должен состоять из 6 цифр.");
                }
            }
        }

        public int RecordNumber { get; }

        public string Group
        {
            get => _group;
            set
            {
                CheckStringLength(value, 10);
                _group = value;
            }
        }

        public string Faculty { get; set; }

        public string FormOfEducation { get; set; }

        public string Info
        {
            get
            {
                return $"{FullName} - {Group} / {Faculty}";
            }
        }

        private static void CheckStringLength(string value, int maxLength, [CallerMemberName] string propertyName = "")
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} не может содержать больше {maxLength} символов.");
            }
        }

        public Student()
        {
            AllStudentsCount++;
            RecordNumber = AllStudentsCount;
        }

        public Student(string fullName, string group, string faculty, string formOfEducation)
        {
            FullName = fullName;
            AllStudentsCount++;
            RecordNumber = AllStudentsCount;
            Group = group;
            Faculty = faculty;
            FormOfEducation = formOfEducation;
        }
    }
}
