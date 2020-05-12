using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App35.Views
{
    [QueryProperty(nameof(BackData), "backdata")]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public int Count { get; set; }
        
        void ButtonClick_Clicked(object sender, EventArgs e)
        {
            Count++;
            OnPropertyChanged(nameof(Count));
        }

        async void ButtonNavigate_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"page2?count={Count}");
        }

        string backData = "";
        public string BackData
        {
            get => backData;
            set
            {
                backData = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }
    }
}