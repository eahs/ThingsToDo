using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;

namespace DoingThing.Views
{
    [DesignTimeVisible(false)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await CrossShare.Current.OpenBrowser("https://weather.com/weather/today/l/39e769d524266cb2052b2020462bac4f1f3cf871cec68b215d449ed45109f12a");
        }

    }
}