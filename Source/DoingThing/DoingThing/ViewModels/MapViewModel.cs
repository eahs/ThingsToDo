using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace DoingThing.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public MapViewModel()
        {
            Title = "Map";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}