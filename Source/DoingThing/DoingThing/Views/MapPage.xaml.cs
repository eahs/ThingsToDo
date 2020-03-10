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

            var pin1 = new GuidePin(new Position(40.692140, -75.259740), "Regal Cinema");
            var pin2 = new GuidePin(new Position(40.695932, -75.2054542), "Bushkill Creek ");
            var pin3 = new GuidePin(new Position(40.693130, -75.202860), "Delaware River Canal ");
            var pin4 = new GuidePin(new Position(40.687290, -75.250400), "State Theatre ");
            var pin5 = new GuidePin(new Position(40.702150, -75.251170), "Bushkill Park ");
            var pin6 = new GuidePin(new Position(40.661940, -75.297010), "Freefall Trampoline Park ");
            var pin7 = new GuidePin(new Position(40.661900, -75.239326), "Canal Museum ");
            var pin8 = new GuidePin(new Position(40.687260, -75.355360), "Dutch Springs ");
            var pin9 = new GuidePin(new Position(40.580820, -75.330660), "Lost River Caverns ");
            var pin10 = new GuidePin(new Position(40.761463, -75.227664), "Klein Farms ");
            var pin11 = new GuidePin(new Position(40.691107, -75.202610), "Twin Rivers Tubing "); 
            var pin13 = new GuidePin(new Position(40.755096, -75.304337), "Martin Guitar Factory ");
            var pin14 = new GuidePin(new Position(40.690670, -75.209780), "Crayola Factory");
            var pin15 = new GuidePin(new Position(40.5949163, -75.5085167), "Lehigh Valley Grand Prix ");
            var pin16 = new GuidePin(new Position(40.7844359, -75.2929651), "Jacobsburg State Park ");
            var pin17 = new GuidePin(new Position(40.81073, -75.520864), "Blue Mountain Resort "); 



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
            map.Pins.Add(pin11); 
            map.Pins.Add(pin13);
            map.Pins.Add(pin14);
            map.Pins.Add(pin15);
            map.Pins.Add(pin16);
            map.Pins.Add(pin17); 

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map); 
            Content = stack;
        }

    }
}