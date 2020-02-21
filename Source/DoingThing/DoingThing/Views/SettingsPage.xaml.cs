using System;
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
			Boolean toggle = App.Toggle(true);
			InitializeComponent();
             

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
            if(Music.On == toggle)
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


