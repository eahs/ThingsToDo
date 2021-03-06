﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoingThing.Models;

namespace DoingThing.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {

                new Item { Id = Guid.NewGuid().ToString(), Text = "Movies", Description="Want to watch the latest movie, take an excursion to the nearest movie theatre."
                , Website="https://www.google.com"
                , Location= "Regal Northhampton Cinema & RPX, Nazareth Road, Easton, PA"
                , Url= "regalCinema.jpg"
                , FC = "40.692140"
                , SC = "-75.259740"
                , Dollar = "Dollar.png"
                , Hours =
                " Sun 11:00AM-11:30PM \n" +
                " Mon 11:00AM-11:30PM \n" +
                " Tue 11:00AM-11:30PM \n" +
                " Wed 11:00AM-11:30PM \n" +
                " Thu 11:00AM-11:30PM \n" +
                " Fri 11:00AM-11:30PM \n" +
                " Sat 11:00AM-11:30PM \n"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "River Bike Path", Description= "Take a bike ride near the river at bushkill creek."
                , Website="https://www.google.com"
                , Location= "Bushkill Creek, PA"
                , Url= "bushkill.jpg"
                , FC = "40.695932"
                , SC = "-75.2054542"
                , Hours =
                "Open All Hours"
                },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Crayola Factory", Description="Take a tour inside of the crayola factory and see how crayons are made."
                , Website="https://www.google.com"
                , Location= "Crayola Experience, 30 Centre Square, Easton, PA 18042"
                , Url= "crayola.jpg"
                , FC = "40.690670"
                , SC = "-75.209780"
                , Dollar = "Dollar.png"
                , Hours =
                " Sun 10:00AM–6:00PM \n" +
                " Mon 10:00AM-4:00PM \n" +
                " Tue 10:00AM-4:00PM \n" +
                " Wed 10:00AM-4:00PM \n" +
                " Thu 10:00AM-4:00PM \n" +
                " Fri 10:00AM-4:00PM \n" +
                " Sat 10:00AM-6:00PM \n"
                },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Fishing", Description="Go fishing and catch some trout down at the Delaware river canal."
                , Website="https://www.google.com"
                , Location= "Philipsburg boat ramp, Delaware River, Riverside Way, Philipsburg, NJ"
                , Url= "philipsburgRamp.jpg"
                , FC = "40.693130"
                , SC = "-75.202860"
                , Hours =
                " Hours Unavailable Online \n"
                },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Plays", Description="Bored, go see a play at downtown easton."
                , Website="https://www.google.com"
                , Location= "State Theatre Center for the Arts, Northhampton Street, Easton, PA"
                , Url= "stateTheater.jpg"
                , FC = "40.687290"
                , SC = "-75.250400"
                , Dollar = "Dollar.png"
                , Hours =
                " Sun Closed \n" +
                " Mon 10:00AM-4:00PM \n" +
                " Tue 10:00AM-4:00PM \n" +
                " Wed 10:00AM-4:00PM \n" +
                " Thu 10:00AM-4:00PM \n" +
                " Fri 10:00AM-4:00PM \n" +
                " Sat Closed \n"},


                 new Item { Id = Guid.NewGuid().ToString(), Text = "Bushkill Park", Description="Bushkill Park is a great place for family fun and a great way to kill some time"
                 , Website="https://www.google.com"
                 , Location= "Bushkill Park, 2100 Bushkill Park Dr, Easton, PA"
                , Url= "bushkillPark.jpg"
                , FC = "40.702150"
                , SC = "-75.251170"
                 ,
                     Hours =
                " Sun 11:00AM-11:30PM \n" +
                " Mon 11:00AM-11:30PM \n" +
                " Tue 11:00AM-11:30PM \n" +
                " Wed 11:00AM-11:30PM \n" +
                " Thu 11:00AM-11:30PM \n" +
                " Fri 11:00AM-11:30PM \n" +
                " Sat 11:00AM-11:30PM \n" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Freefall Trampoline Park", Description="Indoor trampoline park"
                , Website="https://www.google.com"
                , Location= "Freefall Trampoline Park, 2800 Baglyos Cir, Bethlehem, PA"
                , Url= "freefall.jpg"
                , FC = "40.661940"
                , SC = "-75.297010"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun 9:00AM-9:00PM \n" +
                " Mon 10:00AM-9:00PM \n" +
                " Tue 10:00AM-9:00PM \n" +
                " Wed 10:00AM-9:00PM \n" +
                " Thu 10:00AM-9:00PM \n" +
                " Fri 10:00AM-10:00PM \n" +
                " Sat 9:00AM-10:00PM \n"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Canal Museum", Description="A museum where you can relive the past of the creators of the canal."
                , Website="https://www.google.com"
                , Location= "National Canal Museum, 2750 Hugh Moore Park Rd, Easton, PA 18042"
                , Url= "canal.jpg"
                , FC = "40.661900"
                , SC = "-75.239326"
                ,
                    Hours =
                " Sun 11:29AM–4:30PM \n" +
                " Mon Closed \n" +
                " Tue Closed \n" +
                " Wed 11:29AM–4:30PM \n" +
                " Thu 11:29AM–4:30PM \n" +
                " Fri 11:29AM–4:30PM \n" +
                " Sat 11:30AM–4:30PM \n"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Dutch Springs", Description="A really fun water park."
                , Website="https://www.google.com"
                , Location= "Dutch Springs, 4733 Hanoverville Rd, Bethlehem, PA 18020"
                , Url= "dutchSprings.jpg"
                , FC = "40.687260"
                , SC = "-75.355360"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun 10:00AM-7:45PM \n" +
                " Mon 10:00AM-7:45PM \n" +
                " Tue 10:00AM-7:45PM \n" +
                " Wed 10:00AM-7:45PM \n" +
                " Thu 10:00AM-7:45PM \n" +
                " Fri 10:00AM-7:45PM \n" +
                " Sat 10:00AM-7:45PM \n"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Lost River Caverns", Description="Explore underground cave systems."
                , Website="https://www.google.com"
                , Location= "726 Durham St Hellertown, PA 18055"
                , Url= "lostrivercaverns.jpg"
                , FC = "40.580820"
                , SC = "-75.330660"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun 9:00AM-5:00PM \n" +
                " Mon 9:00AM-5:00PM \n" +
                " Tue 9:00AM-5:00PM \n" +
                " Wed 9:00AM-5:00PM \n" +
                " Thu 9:00AM-5:00PM \n" +
                " Fri 9:00AM-5:00PM \n" +
                " Sat 9:00AM-5:00PM \n" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Klein Farms", Description="Go to klein farms and experince the day as a farmer."
                , Website="https://www.google.com"
                , Location= "726 Durham St Hellertown, PA 18055"
                , Url= "kleinfarms.jpg"
                , FC = "40.761463"
                , SC = "-75.227664"
                ,
                    Hours =
                " Sun 8:00AM-7:00PM \n" +
                " Mon 8:00AM-7:00PM \n" +
                " Tue 8:00AM-7:00PM \n" +
                " Wed 8:00AM-7:00PM \n" +
                " Thu 8:00AM-7:00PM \n" +
                " Fri 8:00AM-7:00PM \n" +
                " Sat 8:00AM-7:00PM \n" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Twin Rivers Tubing", Description="Go tubing on the rough and rampid delaware to have some action."
                , Website="https://www.google.com"
                , Location= "4 Union Square, Phillipsburg, NJ 08865"
                , Url= "twinriverstubing.jpg"
                , FC = "40.691107"
                , SC = "-75.202610"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun 11:00AM-6:00PM \n" +
                " Mon Closed \n" +
                " Tue Closed \n" +
                " Wed Closed \n" +
                " Thu Closed \n" +
                " Fri Closed \n" +
                " Sat 11:00AM-6:00PM \n" },

                //new Item { Id = Guid.NewGuid().ToString(), Text = "Escape Room", Description="N/A"
                //, Location= "4210 Fritch Dr, Bethlehem, PA 18020"
                //, FC = "40.682311"
                //, SC = "-75.344597"
                //, Dollar = "Dollar.png"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Martin Guitar Factory", Description="Take a look into how guitars are made and examine how they are built into reality."
                , Website="https://www.google.com"
                , Location= "510 Sycamore St, Nazareth, PA 18064"
                , Url= "martinguitar.jpg"
                , FC = "40.755096"
                , SC = "-75.304337"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun Currently Unavailable \n" +
                " Mon 8:00AM-5:00PM \n" +
                " Tue 8:00AM-5:00PM \n" +
                " Wed 8:00AM-5:00PM \n" +
                " Thu 8:00AM-5:00PM \n" +
                " Fri 8:00AM-5:00PM \n" +
                " Sat Currently Unavailable \n" },

                new Item { Id = Guid.NewGuid().ToString(), Text = "Lehigh Valley Grand Prix", Description="High-speed, indoor go-karting for all ages on a 1/4-mile track, as well as a casual bar & grill."
                , Location= "649 S 10th St, Allentown, PA 18103 "
                , Url= ""
                , FC = "40.5949163"
                , SC = "-75.5085167"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                "N/A"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Jacobsburg State Park", Description="Jacobsburg Environmental Education Center is a 1,168-acre Pennsylvania state park near Wind Gap, in Bushkill Township, Northampton County in Pennsylvania, in the United States. The Jacobsburg National Historic District is almost entirely surrounded by the park."
                , Location= "649 S 10th St, Allentown, PA 18103 "
                , Url= ""
                , FC = "40.7844359"
                , SC = "-75.2929651"
                ,
                 Hours =
                "N/A"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Blue Mountain Resort", Description="Blue Mountain Resort is a ski resort located near Palmerton, Pennsylvania, on Blue Mountain in the northern part of the Lehigh Valley, in Pennsylvania. Blue Mountain serves the Allentown, Philadelphia, New York City, and Wilmington urban areas, as well as Carbon County, Schuylkill County, and the Hazleton area. "
                , Location= "1660 Blue Mountain Dr, Palmerton, PA 18071"
                , Url= ""
                , FC = "40.81073"
                , SC = "-75.520864"
                , Dollar = "Dollar.png"
                ,
                    Hours =
                " Sun 8:00AM-10:00PM \n" +
                " Mon 9:00AM-9:00PM \n" +
                " Tue 9:00AM-9:00PM \n" +
                " Wed 9:00AM-9:00PM \n" +
                " Thu 9:00AM-10:00PM \n" +
                " Fri 9:00AM-10:00PM \n" +
                " Sat 8:00AM-10:00PM" },

                 new Item { Id = Guid.NewGuid().ToString(), Text = "Simon Silk Mill", Description="A creative live/work complex and cultural redevelopment project."
                , Website="https://www.google.com"
                , Location= "Simon Silk Mill, 1262 Simon Blvd, B104 Easton, PA 18042"
                , Url= "download.jpg"
                , FC = "40.604444"
                , SC = "-75.393611"
                , Hours =
                " Mon 8:30am-4:30PM \n" +
                " Tue 8:30AM-4:30PM \n" +
                " Wed 8:30AM-4:30PM \n" +
                " Thu 8:30AM-4:30PM \n" +
                " Fri 8:30AM-4:30PM \n"},
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}