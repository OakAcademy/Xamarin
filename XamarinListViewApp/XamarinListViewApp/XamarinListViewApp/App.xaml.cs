using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinListViewApp.Views;

namespace XamarinListViewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new ListPage());
            carouselPage.Children.Add(new GroupedListPage());

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
