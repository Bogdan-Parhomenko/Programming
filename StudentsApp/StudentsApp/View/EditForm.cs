using StudentsApp.Model.Classes;
using System.Windows.Forms;

namespace StudentsApp.View
{
    public partial class EditForm : Form
    {
        private Student _currentStudent;

        public Student EditStudent { get; set; }

        public EditForm()
        {
            InitializeComponent();
        }
    }
}
