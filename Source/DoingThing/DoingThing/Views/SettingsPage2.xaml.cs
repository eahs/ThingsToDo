using System;
using Xamarin.Forms;
namespace DoingThing.Views
{
    public class SettingsPage2 : ContentPage
    {
        public SettingsPage2()
        {
            Boolean toggle = App.Toggle(true);

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
            if (Music.On == true)
            {
                Music.OnChanged += (sender, e) =>
                {
                    App.Player();
                };
            }
             
                DarkMode.OnChanged += (sender, e) =>
                {
                    App.DarkMode();
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


