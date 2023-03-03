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
            FileInfo[] allfiles = directory.GetFiles("*.cs");
            int fileExtensionLength = 3; // .cs
            foreach (FileInfo file in allfiles)
            {
                EnumsListBox.Items.Add(file.Name.Substring(0, file.Name.Length - fileExtensionLength));
            }
            //EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.DataSource = Enum.GetValues(Type.GetType(EnumsListBox.Text));
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
        }

        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
