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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
    }
}
