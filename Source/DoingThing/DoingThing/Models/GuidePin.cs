using System;
using Xamarin.Forms.Maps;

namespace DoingThing.Models
{
    public class GuidePin : Pin
    { 

 

        public GuidePin(Position coordinates, string label ) 
        {
            Type = PinType.Place;
            Position = coordinates;
            Label = label; 
        }
    }
}
