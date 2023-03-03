using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(@"..\..\Model\Enums");
            FileInfo[] allFiles = directory.GetFiles("*.cs");
            int fileExtensionLength = 3; // .cs
            foreach (FileInfo file in allFiles)
            {
                EnumsListBox.Items.Add(file.Name.Substring(0, file.Name.Length - fileExtensionLength));
            }
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsListBox.Text));
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Weekday), WeekdayParsingTextBox.Text))
            {
                int weekDayNumber = (int)Enum.Parse(typeof(Weekday),WeekdayParsingTextBox.Text);
                WeekdayAnswerLable.Text = $"Это день недели ({WeekdayParsingTextBox.Text} = {weekDayNumber+1})";
            }
            else
            {
                WeekdayAnswerLable.Text = "Нет такого дня недели";
            }
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch (SeasonHandleComboBox.Text)
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!", "Лето");
                    break;
                case "Autumn":
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    TabControl.BackColor = BackColor;
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!", "Зима");
                    break;
                case "Spring":
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    TabControl.BackColor = BackColor;
                    break;
                default:
                    MessageBox.Show("Нет такого времени года");
                    break;
            }
        }
    }
}