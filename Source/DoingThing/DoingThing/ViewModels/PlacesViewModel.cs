using DoingThing;
using DoingThing.Helpers;
using DoingThing.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace FBLAManager.ViewModels
{
    public class PlacesViewModel : BaseViewModel
    {
        public ObservableCollection<Place> Places { get; set; }

        public PlacesViewModel(int level = 0)
        {
            Places = new ObservableCollection<Place>();

            LoadItemsCommand.Execute(null);

        }

        protected override async Task LoadItemsAsync()
        {

            try
            {

                // Make async request to obtain data
                var client = new RestClient(GlobalConstants.EndPointURL);
                var request = new RestRequest
                {
                    Timeout = GlobalConstants.RequestTimeout
                };
                request.Resource = GlobalConstants.MeetingEndPointRequestURL;

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var items = JsonConvert.DeserializeObject<List<Place>>(response.Content) ?? new List<Place>();


                    Places.Clear();

                    foreach (var Place in items)
                    {
                        Places.Add(Place);
                    }

                    OnPropertyChanged("Places");

                    IsError = false;
                    DataAvailable = true;
                }
                else
                {
                    // An error occurred that is stored
                    ErrorMessage = "An error occurred";
                    DataAvailable = false;
                    IsError = true;
                }
            }
            catch (Exception)
            {
                // An exception occurred
                DataAvailable = false;
            }
        }

    }
}