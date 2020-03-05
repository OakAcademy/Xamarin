using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElementsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementsPage3 : ContentPage
    {
        public ElementsPage3()
        {
            InitializeComponent();

            datePicker.MinimumDate = DateTime.Now.AddYears(-1);
            datePicker.MaximumDate = DateTime.Now.AddMonths(1);
            datePicker.Date = DateTime.Now;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            var selectedItem = picker.SelectedItem;
            image.HeightRequest = Convert.ToDouble(selectedItem);
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            activityIndicator.IsRunning = true;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            activityIndicator.IsRunning = false;
        }
    }
}