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
    public partial class SelectCurrencyPage : ContentPage
    {
        SettingsPage settingsPage;
        public SelectCurrencyPage(SettingsPage sender)
        {
            InitializeComponent();
            settingsPage = sender;
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {
            var textCell = (TextCell)sender;
            settingsPage.SetCurrency(textCell.Text);
            Navigation.PopToRootAsync();
        }
    }
}