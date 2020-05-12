using App35.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App35
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Page2), typeof(Page2));
            Routing.RegisterRoute(nameof(Page3), typeof(Page3));
        }
    }
}
