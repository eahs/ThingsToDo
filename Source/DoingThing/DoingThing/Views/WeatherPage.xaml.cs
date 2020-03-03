using Plugin.Share;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace DoingThing.Views
{
    [DesignTimeVisible(false)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        { 
            InitializeComponent();
            {
                webView = new WebView
                {
                    Source = "https://weather.com/weather/today/l/39e769d524266cb2052b2020462bac4f1f3cf871cec68b215d449ed45109f12a",
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };


                // toolbar
                ToolbarItems.Add(new ToolbarItem("Back", null, () =>
                {
                    webView.GoBack();
                }));

                Content = new StackLayout
                {
                    Children = { webView }
                };
            }
        }
    }
}