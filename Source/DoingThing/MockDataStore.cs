using System;
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
				new Item { Id = Guid.NewGuid().ToString(), Text = "River Bike Path", Description= "Take a bike ride near the river at bushkill creek."
                , Location= "Bushkill Creek, PA"
                , Link="A"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Crayola Factory", Description="Take a tour inside of the crayola factory and see how crayons are made."
                , Location= "Crayola Experience, 30 Centre Square, Easton, PA 18042"
                , Link="B"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Bushkill Park", Description="Take a day off and chill at the park."
                , Location= "2100 Bushkill Park Dr, Easton, PA 18040"
                , Link="C"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Fishing", Description="Go fishing and catch some trout down at the Delaware river canal."
                , Location= "Philipsburg boat ramp, Delaware River, Riverside Way, Philipsburg, NJ"
                , Link="D"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Plays", Description="Bored, go see a play at downtown easton."
                , Location= "State Theatre Center for the Arts, Northhampton Street, Easton, PA"
                , Link="E"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Movies", Description="Want to watch the latest movie, take an excursion to the nearest movie theatre."
                , Location= "Regal Northhampton Cinema & RPX, Nazareth Road, Easton, PA"
                , Link="F"},

                 new Item { Id = Guid.NewGuid().ToString(), Text = "Bushkill Park", Description="Bushkill Park is a great place for family fun and a great way to kill some time"
                , Location= "Bushkill Park, 2100 Bushkill Park Dr, Easton, PA"
                , Link="G"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Freefall Trampoline Park", Description="Indoor trampoline park"
                , Location= "Freefall Trampoline Park, 2800 Baglyos Cir, Bethlehem, PA"
                , Link="H"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "National Canal Museum", Description="A museum where you can relive the past of the creators of the canal"
                , Location= "National Canal Museum, 2750 Hugh Moore Park Rd, Easton, PA 18042"
                , Link="I"},

                new Item { Id = Guid.NewGuid().ToString(), Text = "Dutch Springs", Description="Water park"
                , Location= "Dutch Springs, 4733 Hanoverville Rd, Bethlehem, PA 18020"
                , Link="J"}
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