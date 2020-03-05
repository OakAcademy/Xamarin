using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPagesApp.Views;

namespace XamarinPagesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyNavigationPage());
            //MainPage = new NavigationPage(new MyNavigationPage2()) { BarBackgroundColor=Color.GreenYellow, BarTextColor=Color.Red };

            //MainPage = new MyTabbedPage();

            //TabbedPage tabbedPage = new TabbedPage();
            //tabbedPage.Children.Add(new MyContentPage() { Title="Content Page 1"});
            //tabbedPage.Children.Add(new MyContentPage2());

            //MainPage = tabbedPage;

            //MainPage = new MyCarouselPage();

            //CarouselPage carouselPage = new CarouselPage();
            //carouselPage.Children.Add(new MyContentPage());
            //carouselPage.Children.Add(new MyContentPage2());
            //MainPage = carouselPage;

            //MainPage = new MyMasterDetailPage();

            //MainPage = new MyMasterDetailPage2();

            //carouselPage.Title = "Carousel Page";

            //MasterDetailPage masterDetailPage = new MasterDetailPage();
            //masterDetailPage.Master = new MyContentPage() { Title = "Title Content Page" };
            //masterDetailPage.Detail = new NavigationPage( carouselPage);

            //MainPage = masterDetailPage;
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
