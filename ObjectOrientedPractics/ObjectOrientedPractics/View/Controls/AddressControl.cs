using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Содержит логику интерфейса адреса.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Экземпляр адреса покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                FillAllTextBoxes();
            }
        }

        /// <summary>
        /// Очищает все поля на форме. 
        /// </summary>
        /// <param name="isSelected">Определяет выбран ли элемент при очистке.</param>
        public void ClearAllTextBoxes(bool isSelected)
        {
            if (isSelected)
            {
                IndexTextBox.TextChanged -= IndexTextBox_TextChanged;
                IndexTextBox.Clear();
                IndexTextBox.TextChanged += IndexTextBox_TextChanged;

                CountryTextBox.TextChanged -= CountryTextBox_TextChanged;
                CountryTextBox.Clear();
                CountryTextBox.TextChanged += CountryTextBox_TextChanged;

                CityTextBox.TextChanged -= CityTextBox_TextChanged;
                CityTextBox.Clear();
                CityTextBox.TextChanged += CityTextBox_TextChanged;

                StreetTextBox.TextChanged -= StreetTextBox_TextChanged;
                StreetTextBox.Clear();
                StreetTextBox.TextChanged += StreetTextBox_TextChanged;

                BuildingTextBox.TextChanged -= BuildingTextBox_TextChanged;
                BuildingTextBox.Clear();
                BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;

                ApartmentTextBox.TextChanged -= ApartmentTextBox_TextChanged;
                ApartmentTextBox.Clear();
                ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            }
            else
            {
                IndexTextBox.Clear();
                CountryTextBox.Clear();
                CityTextBox.Clear();
                StreetTextBox.Clear();
                BuildingTextBox.Clear();
                ApartmentTextBox.Clear();
            }
        }

        /// <summary>
        /// Заполняет все поля на форме значениями адреса.
        /// </summary>
        private void FillAllTextBoxes()
        {
            if (Address == null)
            {
                ClearAllTextBoxes(false);
                return;
            }
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Создает объект типа <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Присваивает значение из IndexTextBox в свойство Index адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextBox.BackColor = Color.White;
                _address.Index = int.Parse(IndexTextBox.Text);
            }
            catch
            {
                IndexTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из CountryTextBox в свойство Country адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из CityTextBox в свойство City адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из StreetTextBox в свойство Street адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из BuildingTextBox в свойство Building адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из ApartmentTextBox в свойство Apartment адреса.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
