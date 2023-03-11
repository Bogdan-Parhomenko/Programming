using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming
{
    public partial class MainForm : Form
    {
        // Создание массива и переменной класса Rectangle
        private Random random = new Random();
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Добавление значений в Listbox и ComboBox
            object[] enums = new object[]
            {
                typeof(Color),
                typeof(EducationForm),
                typeof(Genre),
                typeof(Manufactures),
                typeof(Season),
                typeof(Weekday)
            };
            EnumsListBox.Items.AddRange(enums);

            // Инициализация массива _rectangles
            for(int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(random.NextDouble() * 101,
                    random.NextDouble() * 101,
                    Enum.GetNames(typeof(Color))[random.Next(8)]);
                RectanglesListBox.Items.Add($"Rectangle {i+1}");
            }
        }

        // При обновлении значения в EnumListBox обновляем значение в ValueListBox
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsListBox.Text));
        }

        // При обновлении значения в ValueListBox выводим номер этого значения в ValueTextBox
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
        }

        // Вводим текст и выводим день недели с его номером при совпадении
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if(Enum.IsDefined(typeof(Weekday), WeekdayParsingTextBox.Text))
            {
                int weekDayNumber = (int)Enum.Parse(typeof(Weekday),WeekdayParsingTextBox.Text);
                WeekdayAnswerLable.Text = $"Это день недели ( {WeekdayParsingTextBox.Text} = {weekDayNumber} )";
            }
            else
            {
                WeekdayAnswerLable.Text = "Нет такого дня недели";
            }
        }

        // В зависимости от выбранного времени года выполняем определенное действие
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

        // При обновлении значения RectanglesListBox запоминаем выбранный Rectangle в _currentRectangle
        // и заполняем Принадлежащие ему TextBox
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        // При изменении значения в LengthTextBox проверяем верность введенных данных
        // и обновлем данные массива Rectangles[]
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
        }

        // При изменении значения в WidthTextBox проверяем верность введенных данных
        // и обновлем данные массива Rectangles[]
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // При изменении значения в ColorTextBox проверяем верность введенных данных
        // и обновлем данные массива Rectangles[]
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}