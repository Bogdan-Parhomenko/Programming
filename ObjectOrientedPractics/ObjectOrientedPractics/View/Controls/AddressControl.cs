using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();

        public Address Address { get; set; }

        public AddressControl()
        {
            InitializeComponent();
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityLabel.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

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
