using System.Collections.Generic;

namespace DoingThing.Models
{
    public class PlaceType
    { 
        public int PlaceTypeId { get; set; }
         
        public string Category { get; set; }
         
        public List<Place> Places { get; set; }
    }
}