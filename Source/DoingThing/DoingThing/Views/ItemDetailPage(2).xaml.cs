using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;
using DoingThing.Models;
using DoingThing.ViewModels;

namespace DoingThing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        public void a (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.youtube.com");
        }
        public void b (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.facebook.com");
        }
        public void c (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void d (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void e (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void f (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void g (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void h (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void i (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
        public void j (object sender, EventArgs e)
        {
            CrossShare.Current.OpenBrowser("https://www.google.com");
        }
    }
}