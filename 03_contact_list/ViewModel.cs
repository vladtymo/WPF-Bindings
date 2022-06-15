using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _03_contact_list
{
    public class ViewModel
    {
        private ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        public ViewModel()
        {
            contacts.Add(new Contact() { Name = "Vova", Age = 30, Surname = "Pupkin", Phone = "+3807575828", IsMale = true });
            contacts.Add(new Contact() { Name = "Marusia", Age = 25, Surname = "Shishik", Phone = "+380771244", IsMale = false });
            contacts.Add(new Contact() { Name = "Olga", Age = 33, Surname = "Shelesh", Phone = "+38067285792", IsMale = false });
        }

        // ! You can bind to public property only
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }

        public void DeleteSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Remove(SelectedContact);
        }
        public void DublicateSelectedContact()
        {
            if (SelectedContact != null)
                contacts.Add(SelectedContact.Clone());
        }
        public void DeleteAllContacts()
        {
            if (contacts.Any())
                contacts.Clear();
        }
    }
}
