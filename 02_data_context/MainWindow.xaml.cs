using System;
using System.Collections.Generic;
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

namespace _02_data_context
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

            this.DataContext = viewModel;
        }
    }

    public class ViewModel
    {
        public User MyUser1 { get; set; }
        public User MyUser2 { get; set; }

        public ViewModel()
        {
            MyUser1 = new User()
            {
                Name = "Bob",
                Email = "bobovich@gmail.com"
            };
            MyUser2 = new User()
            {
                Name = "John",
                Email = "vidlfjf@gmail.com"
            };
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
