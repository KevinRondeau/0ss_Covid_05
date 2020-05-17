using BillingManagement.UI.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {

        public MainWindowView()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

    }
}
