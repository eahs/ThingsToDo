using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DoingThing.ViewModels
{
    public class WeatherViewModel : BaseViewModel
    {
        public WeatherViewModel()
        {
            Title = " Weather";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}