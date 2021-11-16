using ContactsBook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ContactsBook.ContactServices
{
    public class ContactService
    {
        public static ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>();
        public void AddContact( Contact contact ) { _contacts.Add(contact); }
        public int GeneratedId()
        {
            if ( _contacts.Count > 0 )
            {
                return _contacts.Max(c => c.Id) + 1;
            }
            return 0;
        }
        public void UpdateContact( int contactId, string fName, string lName, string phone, string email, bool blocked )
        {
            Contact contact = _contacts.First(c => c.Id == contactId);
            contact.FirstName = fName;
            contact.LastName = lName;
            contact.Phone = phone;
            contact.Email = email;
            contact.IsBlock = blocked;
        }

        
    }
}
