using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Controls
{
    public partial class AllEnumerationsControl : UserControl
    {
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

            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsListBox.Text));
            ValuesListBox.SelectedIndex = 0;
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
        }
    }
}
