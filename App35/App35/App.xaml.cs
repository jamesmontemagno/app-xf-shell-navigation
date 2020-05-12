using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App35.Views;

namespace App35
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
