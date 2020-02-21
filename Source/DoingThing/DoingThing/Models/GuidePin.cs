using System;
using Xamarin.Forms.Maps;

namespace DoingThing.Models
{
    public class GuidePin : Pin
    {
        public GuidePin(Position coordinates, string label, string address) 
        {
            Type = PinType.Place;
            Position = coordinates;
            Label = label;
            Address = address;
        }
    }
}
