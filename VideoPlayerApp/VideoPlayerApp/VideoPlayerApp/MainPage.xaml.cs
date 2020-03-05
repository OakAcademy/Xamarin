using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoPlayerApp.Views;
using Xamarin.Forms;

namespace VideoPlayerApp
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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CheckPermission();
        }

        private async void CheckPermission()
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
            if (status != PermissionStatus.Granted)
            {
                var permissions=await CrossPermissions.Current.RequestPermissionsAsync(Permission.Storage);
                status = permissions[Permission.Storage];
            }

            GoToVideoListPage();
        }

        private void GoToVideoListPage()
        {
            App.Current.MainPage = new NavigationPage(new VideoListPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            GoToVideoListPage();
        }
    }
}
