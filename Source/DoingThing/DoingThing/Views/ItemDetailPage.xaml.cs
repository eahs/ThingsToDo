using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;
using DoingThing.Models;
using DoingThing.ViewModels;

namespace DoingThing.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
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
                Link = "This is a link.",
                Url = "This is a Image."
            };


            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public void A(object sender, EventArgs e)
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


    }

}
