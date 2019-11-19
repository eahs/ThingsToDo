using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;
using DoingThing.Models;
using DoingThing.ViewModels;

using Xamarin.Essentials;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoingThing.Views
{
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {

        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description.",
                Location = "This is a location.",
                Url = "This is a Image.",
                FC = "These are the first coords",
                SC = "These are the second coords"
            };


            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }


        private async void ButtonOpenCoords_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;

            if (!double.TryParse(EntryLongitude.Text, out double lng))
                return;

            await Map.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });

        }

        /*public void A(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void B(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void C(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void D(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void E(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void F(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void G(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void H(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void I(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       public void J(object sender, EventArgs e)
       {
           CrossShare.Current.OpenBrowser("https://www.google.com/maps");
       }
       */


    }

}
