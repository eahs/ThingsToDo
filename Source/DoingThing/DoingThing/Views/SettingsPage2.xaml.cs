using System;
using Xamarin.Forms;

namespace DoingThing.Views
{
    public partial class SettingsPage2 : ContentPage
    {
        public SettingsPage2()
        {
            async void Cancel_Click(object sender, EventArgs e)
            {
                 ToolbarItem item = (ToolbarItem)sender;
                 //await Navigation.PushModalAsync(new NavigationPage(new AboutPage()));
            }

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


