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

            EnumsEnumsListBox.DataSource = enums;
            EnumsEnumsListBox.SelectedIndex = 0;
        }

        private void EnumsEnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumsValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsEnumsListBox.Text));
            EnumsValuesListBox.SelectedIndex = 0;
        }

        private void EnumsValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumsIntValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsEnumsListBox.Text), EnumsValuesListBox.Text)).ToString();
        }
    }
}
