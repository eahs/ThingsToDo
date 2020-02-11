using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DoingThing
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public AppShell(Views.AboutPage aboutPage)
        {
            InitializeComponent();
        }
    }
}

