using ContactBookSQLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactBookSQLite
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailContactPage : ContentPage
    {
        bool block = false;
        int contactIddd;
        public DetailContactPage(int contactId)
        {
            InitializeComponent();
            if(contactId==0)
            {
                contactIddd = 0;
            }
            else
            {
                contactIddd = contactId;
                SetInfo(contactId);
            }
            
        }

        private async void Button_Clicked( object sender, EventArgs e )
        {
            string fname = entryFName.Text;
            string lname = entryLName.Text;
            string phone = entryPhone.Text;
            string email = entryEmail.Text;
            if( String.IsNullOrWhiteSpace(fname) || String.IsNullOrWhiteSpace(lname))
            {
                await DisplayAlert("Lỗi", "Tên, Họ không được bỏ trống", "OK");
            }
            else
            {
                if(contactIddd == 0)
                {
                    Contact contact = new Contact() { FName = fname, LName = lname, Phone = phone, Email = email, IsBlock = block };
                    await MainPage._connection.InsertAsync(contact);
                    await Navigation.PopAsync();
                }
                else
                {
                    Contact contact = await MainPage._connection.Table<Contact>().Where(c => c.Id == contactIddd).FirstOrDefaultAsync();
                    contact.FName = fname;
                    contact.LName = lname; 
                    contact.Phone = phone;
                    contact.Email = email;
                    contact.IsBlock = block;
                    await MainPage._connection.UpdateAsync(contact);
                    await Navigation.PopAsync();
                }
                
            }
        }

        private void swBlocked_OnChanged( object sender, ToggledEventArgs e )
        {
            block = e.Value;
        }

        public async void SetInfo( int contactId )
        {
            Contact contact = await MainPage._connection.Table<Contact>().Where(c => c.Id == contactId).FirstOrDefaultAsync();
            entryFName.Text = contact.FName;
            entryLName.Text = contact.LName;
            entryPhone.Text = contact.Phone;
            entryEmail.Text = contact.Email;
            swBlocked.On = contact.IsBlock;
        }
    }
}