using ContactsBook.ContactServices;
using ContactsBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContactsBook
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            listContact.ItemsSource = ContactService._contacts;
        }

        async void ToolbarItem_Clicked( object sender, EventArgs e )
        {
             await Navigation.PushAsync( new ContactDetailPage(1001) );
        }

        async void listContact_ItemSelected( object sender, SelectedItemChangedEventArgs e )
        {   
            if(e.SelectedItem==null)
            {
                return;
            }                           
            var contact = e.SelectedItem;
            await Navigation.PushAsync(new ContactDetailPage((contact as Models.Contact).Id));
            listContact.SelectedItem = null;

        }

        private async void MenuItem_Clicked( object sender, EventArgs e )
        {
            bool a = await DisplayAlert("Xóa liên hệ?", "Liên hệ này sẽ được đưa vào thùng rác.", "Đồng ý", "Hủy");
            if ( a )
            {
                ContactService._contacts.Remove((sender as MenuItem).CommandParameter as Contact);
            }
        }
    }
}
