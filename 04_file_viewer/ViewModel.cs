using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _04_file_viewer
{
    public class ViewModel : INotifyPropertyChanged
    {
        // fileds
        private string directoryPath;
        private FileInfo selectedFile;
        private ObservableCollection<FileInfo> files = new ObservableCollection<FileInfo>();

        public ViewModel()
        {
            LoadFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        // public properties
        public IEnumerable<FileInfo> Files => files;
        public string DirectoryPath
        {
            get => directoryPath;
            set
            {
                this.directoryPath = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(DirectoryName));
            }
        }
        public string DirectoryName => Path.GetFileName(DirectoryPath);
        public FileInfo SelectedFile
        {
            get => selectedFile;
            set
            {
                this.selectedFile = value;
                OnPropertyChanged();
            }
        }

        // methods
        public string OpenDirectory()
        {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }
        public void LoadFiles(string dirPath)
        {
            DirectoryPath = dirPath; // works

            DirectoryInfo directory = new DirectoryInfo(dirPath);
            var data = directory.GetFiles();

            files.Clear();
            foreach (var item in data)
            {
                files.Add(item);
            }
        }
        public void LoadFiles()
        {
            string dir = OpenDirectory();
            LoadFiles(dir);
        }

        // notify event
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
