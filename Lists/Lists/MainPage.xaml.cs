using Lists.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lists
{
    public partial class MainPage : ContentPage
    {
        SearchService s = new SearchService();
        private ObservableCollection<SearchGroup> groups;
        public MainPage()
        {
            InitializeComponent();
            groups = new ObservableCollection<SearchGroup>
            {
                new SearchGroup(s.GetSearch())
            };
            listView.ItemsSource = groups;
            
        }
        /// <summary>
        /// Xóa 1 search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Clicked( object sender, EventArgs e )
        {                              
            var search = (sender as MenuItem).CommandParameter as Search;
            s.DeleteSearch(search.Id);
            groups[0] = new SearchGroup(s._searches);
            listView.ItemsSource = groups;
        }
        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBar_TextChanged( object sender, TextChangedEventArgs e )
        {
            groups[0] = new SearchGroup(s.GetSearch(e.NewTextValue));
            listView.ItemsSource = groups;
        }
        /// <summary>
        /// Pull Refresh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_Refreshing( object sender, EventArgs e )
        {
            groups[0] = new SearchGroup(s._searches);
            listView.ItemsSource = groups;
            listView.IsRefreshing = false;
            listView.EndRefresh();
        }
        /// <summary>
        /// Chọn 1 search và alert Location lên màn hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemSelected( object sender, SelectedItemChangedEventArgs e )
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Location", search.Location, "OK");
        }
    }
}
