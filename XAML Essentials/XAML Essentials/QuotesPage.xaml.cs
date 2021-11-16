using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAML_Essentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        string[] quotes = new string[] { "Hôm nay là một ngày đẹp trời!",
                                         "Baby Shark Duu Duu Duu...",
                                         "Build a simple app for browsing a list of quotes" };
        private int index = 0;
        public QuotesPage()
        {
            InitializeComponent();
            //Set text khi khởi tạo Page
            currentQuote.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Kiểm tra biến index, trả về 0 hoặc tăng lên 1
            index = index < quotes.Length - 1 ? index + 1 : 0;
            //Set lại text trên Label currentQuote
            currentQuote.Text = quotes[index];
        }
    }
}