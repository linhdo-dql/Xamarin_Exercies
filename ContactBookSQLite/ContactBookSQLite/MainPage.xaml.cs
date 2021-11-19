using ContactBookSQLite.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using ContactBookSQLite.DBO;

namespace ContactBookSQLite
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;
        public static SQLiteAsyncConnection _connection;
        public MainPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _connection.CreateTableAsync<Contact>();
            var contacts = await _connection.Table<Contact>().ToListAsync();
            _contacts = new ObservableCollection<Contact>(contacts);
            listContact.ItemsSource = _contacts;
        }

        private async void ToolbarItem_Clicked( object sender, EventArgs e )
        {
            await Navigation.PushAsync(new DetailContactPage(0));
        }

        private async void listContact_ItemSelected( object sender, SelectedItemChangedEventArgs e )
        {
            if ( e.SelectedItem == null ) return;
           await Navigation.PushAsync(new DetailContactPage((e.SelectedItem as Contact).Id));
            listContact.SelectedItem = null;
        }

        private async void MenuItem_Clicked( object sender, EventArgs e )
        {
            bool b = await DisplayAlert("Xóa", "Có chắc chắn muốn xóa liên hệ này?", "Có", "Không");
            if( b )
            {
                Contact contact = (sender as MenuItem).CommandParameter as Contact;
                _contacts.Remove(contact);
                await _connection.DeleteAsync(contact);

            }
        }
    }
}
