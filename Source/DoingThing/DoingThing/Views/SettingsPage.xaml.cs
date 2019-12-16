using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoingThing.Views
{
    public partial class SettingsPage : ContentPage
    {
        public event EventHandler<ToggledEventArgs> Toggled;
        
        public SettingsPage()

        {
            InitializeComponent();
        }

        async void Cancel_Click(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
