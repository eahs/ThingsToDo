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


        public void Start(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppShell());
        }
    }
}
