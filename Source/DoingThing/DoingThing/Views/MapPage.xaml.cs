using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoingThing.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DoingThing.Views
{
    public partial class MapPage : ContentPage
    { 

        readonly Map map;
        public MapPage()
        {
            var map = new Map(
                MapSpan.FromCenterAndRadius(
                        new Position(40, -75), Distance.FromMiles(0.3)))
            {
                IsVisible = true,
                IsEnabled = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            map.MoveToRegion(new MapSpan(new Position(40.691216, -75.209130), 0.01, 0.01));

            StackLayout slMap = new StackLayout
            {
                Children = { map },
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(10, 10, 10, 10)
            };

            map.MapType = MapType.Street;
             
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map); 
            Content = stack;
        }

    }
}