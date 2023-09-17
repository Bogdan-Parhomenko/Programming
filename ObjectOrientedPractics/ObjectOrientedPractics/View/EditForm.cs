using System;
using System.Drawing;
using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class EditForm : Form
    {
        private Item _copiedItem;

        public Item CurrentItem { get; set; }

        public EditForm(Item item)
        {
            InitializeComponent();
            _copiedItem = Item.CopyItem(item);
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = Color.White;
                _copiedItem.Cost = Double.Parse(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                _copiedItem.Name = NameTextBox.Text;
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.BackColor = Color.White;
                _copiedItem.Name = InfoTextBox.Text;
            }
            catch
            {
                InfoTextBox.BackColor = Color.LightPink;
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_copiedItem.Name == null   // _copiedItem.Cost == null
                || _copiedItem.Info == null)
            {
                return;
            }
            if (CostTextBox.BackColor == Color.LightPink 
                || NameTextBox.BackColor == Color.LightPink
                || InfoTextBox.BackColor == Color.LightPink)
            {
                return;
            }
            CurrentItem = _copiedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
