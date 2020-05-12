using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App35.Views
{
    [QueryProperty(nameof(Data), nameof(Data))]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = this;
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Hello");
            }
        }

        public int Count { get; set; }
        
        void ButtonClick_Clicked(object sender, EventArgs e)
        {
            Count++;
            OnPropertyChanged(nameof(Count));
        }

        async void ButtonNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Page2)}?Count={Count}");
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
    }
}