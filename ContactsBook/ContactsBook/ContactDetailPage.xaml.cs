using ContactsBook.ContactServices;
using ContactsBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        ContactService c = new ContactService();
        bool blocked = false;
        int contact = 0;
        public ContactDetailPage(int contactId)
        {
            InitializeComponent();
            if ( contactId == 1001 )
            {
                contact = 1001;
            }
            else { SetInfo(contactId); this.contact = contactId; }
        }

        async void Button_Clicked( object sender, EventArgs e )
        {
            string firstName = entryFName.Text;
            string lastName = entryLName.Text;
            bool block = blocked;
            if ( string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) )
            {
                await DisplayAlert("Lỗi", "Họ, tên không được bỏ trống!", "OK");
                return;
            } 
            else
            {   
              if(contact!=1001)
                {
                    c.UpdateContact(contact, firstName, lastName, entryPhone.Text, entryEmail.Text, block);
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    string phone = entryPhone.Text;
                    string email = entryEmail.Text;
                    Contact contact = new Contact() { Id = c.GeneratedId(), FirstName = firstName, LastName = lastName, Email = email, Phone = phone, IsBlock = blocked };
                    c.AddContact(contact);
                    await Navigation.PushAsync(new MainPage());
                }
            }
            
        }

        private void swBlocked_OnChanged( object sender, ToggledEventArgs e )
        {
            blocked = e.Value;
        }
        
        public void SetInfo(int contactId)
        {
            Contact contact = ContactService._contacts.First(c => c.Id == contactId);
            entryFName.Text = contact.FirstName;
            entryLName.Text = contact.LastName;
            entryPhone.Text = contact.Phone;
            entryEmail.Text = contact.Email;
            swBlocked.On = contact.IsBlock;
        }
    }
}