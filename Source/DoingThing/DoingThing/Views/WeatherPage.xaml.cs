﻿using System;
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
            url.Text = "https://www.accuweather.com";
            Browser.Source = url.Text;
        }

        //async void Weather(object sender, EventArgs e)
        //{
        //    await CrossShare.Current.OpenBrowser("https://weather.com/weather/today/l/39e769d524266cb2052b2020462bac4f1f3cf871cec68b215d449ed45109f12a");
        //}

        //async void Accuweather(object sender, EventArgs e)
        //{
        //    await CrossShare.Current.OpenBrowser("https://www.accuweather.com/en/us/easton/18042/weather-forecast/329553");
        //}

        void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
        }

        void Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }

        void Go_Clicked(object sender, System.EventArgs e)
        {
            Browser.Source = url.Text;
        }

        void Forward_Clicked(object sender, System.EventArgs e)
        {
            if (Browser.CanGoForward)
                Browser.GoForward();
        }

        void Back_Clicked(object sender, System.EventArgs e)
        {
            if (Browser.CanGoBack)
                Browser.GoBack();
        }

    }
     
}