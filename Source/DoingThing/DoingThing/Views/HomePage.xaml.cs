using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoingThing.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        async void Start(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppShell());
        }
    }
}
