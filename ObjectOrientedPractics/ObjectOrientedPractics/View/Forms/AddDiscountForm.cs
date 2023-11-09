using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Содержит логику окна добавления скидки.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает созданную скидку.
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; } = new PercentDiscount();

        /// <summary>
        /// Создает объект типа <see cref="AddDiscountForm"/>.
        /// Инициализирует CategoryComboBox.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        /// <summary>
        /// Присваивает значение в свойство Category.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PercentDiscount.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
        }

        /// <summary>
        /// Принимает новую скидку.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Не принимает новую скидку.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
