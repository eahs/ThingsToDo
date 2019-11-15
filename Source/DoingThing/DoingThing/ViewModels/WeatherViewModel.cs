using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using DoingThing.Models;
using DoingThing.Views;

namespace DoingThing.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {

        public WeatherViewModel()
        {
            Title = "Weather";
        }

    }
}