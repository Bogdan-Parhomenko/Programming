using System;
using System.Drawing;
using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Содержит логику формы изменения товаров.
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary>
        /// Скопированный изменяемый товар.
        /// </summary>
        private Item _copiedItem;

        /// <summary>
        /// Возвращает или задает изменяемый товар.
        /// </summary>
        public Item CurrentItem { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="EditForm"/>.
        /// Заполняет все поля формы данными товара, которого нужно изменить
        /// и копирует их в новый экземпляр класса.
        /// </summary>
        /// <param name="item">Товар, который нужно изменить.</param>
        public EditForm(Item item)
        {
            InitializeComponent();
            _copiedItem = Item.CopyItem(item);
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
        }

        /// <summary>
        /// При изменении текста CostTextBox пытается присвоить этот текст в свойство Cost элемента
        /// _copiedItem и красит CostTextBox в соответствии с валидацией.
        /// </summary>
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

        /// <summary>
        /// При изменении текста NameTextBox пытается присвоить этот текст в свойство Name элемента
        /// _copiedItem и красит NameTextBox в соответствии с валидацией.
        /// </summary>
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

        /// <summary>
        /// При изменении текста InfoTextBox пытается присвоить этот текст в свойство Info элемента
        /// _copiedItem и красит InfoTextBox в соответствии с валидацией.
        /// </summary>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.BackColor = Color.White;
                _copiedItem.Info = InfoTextBox.Text;
            }
            catch
            {
                InfoTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При нажатии на кнопку мзменения товара, если все поля экземпляра товара
        /// не пустые и значения допустимы, то передает его в свойство CurrentItem и закрывает форму.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_copiedItem.Name == null
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

        /// <summary>
        /// При нажатии на кнопку удаления товара удаляет товар и закрывает форму.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
