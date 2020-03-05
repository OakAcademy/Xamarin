using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTableViewApp.Views;

namespace XamarinTableViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new Page1());
            carouselPage.Children.Add(new Page2());
            MainPage = carouselPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
