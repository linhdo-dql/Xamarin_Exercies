using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Photo_Gallery
{
    public partial class MainPage : ContentPage
    {
        private int _index = 1;
        public MainPage()
        {
            InitializeComponent();
            image.Source = "https://lorempixel.com/1920/1080/city/1/";
        }

        private void btnPrevious_Clicked(object sender, EventArgs e)
        {
            _index = _index > 1 ? _index - 1 : 10;
            image.Source = "https://lorempixel.com/1920/1080/city/" + _index +"//";
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            _index = _index < 10 ? _index + 1 : 1;
            image.Source = "https://lorempixel.com/1920/1080/city/" + _index +"//";
        }
    }
}
