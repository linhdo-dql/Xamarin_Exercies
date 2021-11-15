using InstagramApp;
using Navigation.Models;
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
    public partial class UserProfilePage : ContentPage
    {
        UserService userService = new UserService();
        public UserProfilePage(Activity activity)
        {
            InitializeComponent();
            if(activity == null)
            {
                throw new ArgumentNullException(nameof(activity));
            }
            User user = userService.GetUser(activity.UserId);
            BindingContext = user;
        }
    }
}