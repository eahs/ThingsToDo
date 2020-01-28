using System;

using Xamarin.Forms;

namespace DoingThing.ViewModels
{
    public class StartupViewModel : ContentView
    {
        public StartupViewModel()
        {
            Content = new Label { Text = "Hello ContentView" };
        }
    }
}

