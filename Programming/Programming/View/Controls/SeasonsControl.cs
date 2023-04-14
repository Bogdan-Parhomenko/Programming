using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

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
