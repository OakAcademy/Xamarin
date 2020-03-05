using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinElementsApp.Views;

namespace XamarinElementsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new ElementsPage1());
            carouselPage.Children.Add(new ElementsPage2());
            carouselPage.Children.Add(new ElementsPage3());

            carouselPage.CurrentPage = carouselPage.Children[2];

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
