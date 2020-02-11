﻿using System;
using Xamarin.Forms;

namespace DoingThing.Views
{
    public partial class SettingsPage : ContentPage
    {
        async void Page_Back(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AppShell());
        }

        public SettingsPage()
        {
            InitializeComponent();

            

            Label header = new Label
            {
                Text = "Settings",
                FontSize = 50,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection
                    {
                        new SwitchCell
                        {
                            Text = "Dark Mode:"
                        },
                        new SwitchCell
                        {
                            Text = "Music"
                        },

                    }
                }
            };

            // Build the page.
            Title = "";
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children =
                {
                    header,
                    tableView
                }
            };
        }
    }
}


