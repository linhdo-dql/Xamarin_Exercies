using InstagramApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityPage : ContentPage
    {
        ActivityService activityService = new ActivityService();
        public ActivityPage()
        {
            InitializeComponent();
            listActivities.ItemsSource = activityService.GetActivities();
        }

        async void listActivities_ItemSelected( object sender, SelectedItemChangedEventArgs e )
        {
            if (listActivities.SelectedItem == null)
            {
                return;
            }
            await Navigation.PushAsync(new UserProfilePage(e.SelectedItem as Models.Activity));
            listActivities.SelectedItem = null;
        }
    }
}