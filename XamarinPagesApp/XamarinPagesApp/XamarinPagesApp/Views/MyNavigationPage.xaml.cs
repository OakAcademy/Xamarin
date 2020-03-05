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
    public partial class MyNavigationPage : ContentPage
    {
        public MyNavigationPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new MyContentPage());
            Navigation.PushAsync(new MyContentPage());            
        }
    }
}