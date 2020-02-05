using System;
using System.ComponentModel;
using Plugin.Share;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DoingThing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SettingsPage2()));
        }
        public AboutPage()
        {
            InitializeComponent();
        }

        public void Clicked(object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.eastonsd.org");
        }
        
    }
}