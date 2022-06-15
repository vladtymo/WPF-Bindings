using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace _04_file_viewer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.LoadFiles();
        }
    }
}
