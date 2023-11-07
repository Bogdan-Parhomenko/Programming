using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        public PercentDiscount PercentDiscount { get; set; } = new PercentDiscount();
        /// <summary>
        /// 
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PercentDiscount.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
