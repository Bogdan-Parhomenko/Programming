using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику пользовательского ввода дней недели вкладки Enums.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При нажатии на WeekdayParsingButton если значение в WeekdayParsingTextBox
        /// совпадает с любой из констант перечисления Weekday, то выводит строку с этой константой в WeekdayAnswerLable.
        /// Если значение не совпадает с любой из констант перечисления Weekday, то выводит соответствующую строку
        /// </summary>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(Weekday), WeekdayParsingTextBox.Text))
            {
                var weekDayNumber = (int)Enum.Parse(typeof(Weekday), WeekdayParsingTextBox.Text);
                WeekdayAnswerLable.Text = $"Это день недели ( {WeekdayParsingTextBox.Text} = {weekDayNumber} )";
            }
            else
            {
                WeekdayAnswerLable.Text = "Нет такого дня недели";
            }
        }
    }
}
