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


            var test = new Pin
            {

            };

            var pin1 = new GuidePin(new Position(40.691216, -75.209130), "Center Square", "Historical Location");
            var pin2 = new GuidePin(new Position(40.691389, -75.2125), "State Theater", "Entertainment");
            var pin3 = new GuidePin(new Position(40.691944, -75.213611), "Easton Public Library", "Educational Facility");
            var pin4 = new GuidePin(new Position(40.687306, -75.217623), "NorthHampton County Court House", "Historical Location");
            var pin5 = new GuidePin(new Position(40.691281, -75.210421), "Easton Public Market", "Consumer");
            var pin6 = new GuidePin(new Position(40.690848, -75.210674), "Sigal Museum", "Educational Location");
            var pin7 = new GuidePin(new Position(40.694538, -75.203715), "Easton-Pburg Bridge", "Historical Location");
            var pin8 = new GuidePin(new Position(40.692109, -75.205205), "Christopher Columbus Statue", "Historical Location");
            var pin9 = new GuidePin(new Position(40.690585, -75.213675), "Nurture Nature Center", "Educational LOcation");
            var pin10 = new GuidePin(new Position(40.692191, -75.205048), "RiverSide Park", "Recreation");
            var pin11 = new GuidePin(new Position(40.689864, -75.205397), "Larry Holmes Statue", "Historical Location");


            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
            map.Pins.Add(pin6);
            map.Pins.Add(pin7);
            map.Pins.Add(pin8);
            map.Pins.Add(pin9);
            map.Pins.Add(pin10);

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map); 
            Content = stack;
        }

    }
}