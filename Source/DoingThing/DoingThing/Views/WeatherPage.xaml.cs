using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;

namespace DoingThing.Views
{ 
    [DesignTimeVisible(false)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await CrossShare.Current.OpenBrowser("https://www.google.com/maps/place/Easton,+PA/@40.6789302,-75.2717212,13z/data=!3m1!4b1!4m5!3m4!1s0x89c46b821870585f:0x37203227748fc82b!8m2!3d40.688432!4d-75.2207323");
        }

    }
}