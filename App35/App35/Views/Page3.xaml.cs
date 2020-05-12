using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App35.Views
{

    [QueryProperty(nameof(Data), "data")]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            BindingContext = this;
        }

        string data = "";
        public string Data
        {
            get => data;
            set
            {
                data = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..?backdata=from page 3");
        }
    }
}