using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику выбора перечислений вкладки Enums.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="AllEnumerationsControl"/>.
        /// Инициализирует массив перечислеий enums и заполняет EnumsListBox названиями этих перечислений.
        /// Выбирает первый элемент EnumsListBox.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();

            var enums = new object[]
            {
                typeof(Color),
                typeof(EducationForm),
                typeof(Genre),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// При изменении индекса выбранного элемента EnumsListBox
        /// запоняет ValuesListBox константами выбранного перечисления.
        /// Выбирает первый элемент ValuesListBox.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues((Type)EnumsListBox.SelectedItem);

            ValuesListBox.Items.Clear();

            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }

            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// При изменении индекса выбранного элемента ValuesListBox
        /// Преобразует элемент в числовой вид и записывает его в IntValueTextBox.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
