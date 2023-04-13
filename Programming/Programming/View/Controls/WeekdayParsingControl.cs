using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

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
