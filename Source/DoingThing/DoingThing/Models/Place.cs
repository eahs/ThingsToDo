using System;
using DoingThing.Models;

namespace DoingThing.Models
{
    public class Place
    {
            public int PlaceId { get; set; }

            public int PlaceTypeId { get; set; }

            public PlaceType PlaceType { get; set; }

            public string Location { get; set; }
         
            public string Activity { get; set; }
         
            public string Description { get; set; }
         
            public string Address { get; set; }
         
            public string Hours { get; set; }
         
            public string Cost { get; set; }
         
            public string Latitude { get; set; }
         
            public string Longitude { get; set; }
         
            public string URL { get; set; }
         
            public string Image { get; set; }
    }
}
