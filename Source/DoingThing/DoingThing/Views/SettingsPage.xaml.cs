using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoingThing.Views
{
    public partial class SettingsPage : ContentPage
    {
        void OnToggled(object sender, ToggledEventArgs e)
        {

        }
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
