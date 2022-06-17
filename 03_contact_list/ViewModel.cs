using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace _03_contact_list
{
    public class ViewModel
    {
        // Commands
        private RelayCommand dublicateCommand;
        private RelayCommand removeCommand;
        private RelayCommand clearCommand;

        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        public ViewModel()
        {
            dublicateCommand = new RelayCommand((o) => DublicateSelectedContact(), (o) => SelectedContact != null);
            removeCommand = new RelayCommand((o) => DeleteSelectedContact(), (o) => SelectedContact != null);
            clearCommand = new RelayCommand((o) => contacts.Clear(), (o) => contacts.Any());

            contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });
        }

        // ! You can bind to public property only
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }

        public ICommand DublicateCmd => dublicateCommand;
        public ICommand RemoveCmd => removeCommand;
        public ICommand ClearCmd => clearCommand;

        public void DublicateSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Add(SelectedContact.Clone());
        }
        public void DeleteSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }
    }
}
