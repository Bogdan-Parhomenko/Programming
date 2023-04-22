using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику выбора сезонов вкладки Enums.
    /// </summary>
    public partial class SeasonsControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="SeasonsControl"/>.
        /// Заполняет SeasonHandleComboBox константами перечисления Season.
        /// </summary>
        public SeasonsControl()
        {
            InitializeComponent();

            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        /// <summary>
        /// При нажатии на SeasonHandleButton выполняет определенное действие
        /// в соответствии с выбранным значением в SeasonHandleComboBox.
        /// </summary>
        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch (SeasonHandleComboBox.Text)
            {
                case "Summer":
                    {
                        MessageBox.Show("Ура! Солнце!", "Лето");
                        break;
                    }
                case "Autumn":
                    {
                        SeasonHandleComboBox.BackColor = AppColors.AutumnColor;
                        break;
                    }
                case "Winter":
                    {
                        MessageBox.Show("Бррр! Холодно!", "Зима");
                        break;
                    }
                case "Spring":
                    {
                        SeasonHandleComboBox.BackColor = AppColors.SpringColor;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Нет такого времени года");
                        break;
                    }
            }
        }
    }
}
