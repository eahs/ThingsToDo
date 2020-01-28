using System;
using Xamarin.Forms;
namespace DoingThing.Views
{
    public class SettingsPage2 : ContentPage
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

            SwitchCell Music = new SwitchCell()
            {
                Text = "Music",
            };
            SwitchCell DarkMode = new SwitchCell()
            {
                Text = "Dark Mode",
            };
            TableView tableView = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection
                    {
                        DarkMode,
                        Music,
                    }
                },
                Intent = TableIntent.Form,
            };

            Music.OnChanged += (sender, e) =>
            {
                App.Player();
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


