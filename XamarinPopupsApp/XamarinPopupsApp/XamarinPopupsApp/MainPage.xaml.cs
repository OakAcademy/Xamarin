using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPopupsApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert Title", "This is an Alert", "OK");
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Question Alert Title", "Select Yes or No", "Yes", "No");
            if (result) lblResult.Text = "YES";
            else lblResult.Text = "NO";
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Select Font Size", "CANCEL", null, "20", "25", "30", "35");
            if (result != "CANCEL") lblResult.FontSize = Convert.ToInt32(result);
        }
    }
}
