using System.Windows;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Инициализация компонентов главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainVM();
        }
    }
}
