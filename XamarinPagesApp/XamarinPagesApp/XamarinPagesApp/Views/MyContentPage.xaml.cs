using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPagesApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyContentPage : ContentPage
    {
        public MyContentPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PopModalAsync();
            //Navigation.PopAsync();

            Navigation.PopToRootAsync();
        }
    }
}