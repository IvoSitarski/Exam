using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;
using Exam;

namespace Exam
{
    public partial class MainWindow : Window
    {
        private ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void OpenGuestsWindow(object sender, RoutedEventArgs e)
        {
            GuestsWindow guestsWindow = new GuestsWindow
            {
                DataContext = this.DataContext // Свързваме същия ViewModel
            };
            guestsWindow.Show();
        }
    }
}
