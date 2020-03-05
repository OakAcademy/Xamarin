using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SettingsPageApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void CustomViewCell_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SelectCurrencyPage(this));
        }

        public void SetCurrency(string newCurrency)
        {
            currencyCell.Detail = newCurrency;
        }
    }
}