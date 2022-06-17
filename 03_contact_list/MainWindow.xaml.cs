using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_contact_list
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();

            // View -> ViewModel
            this.DataContext = viewModel;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    viewModel.DeleteSelectedContact();
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    viewModel.DeleteAllContacts();
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    viewModel.DublicateSelectedContact();
        //}
    }
}
