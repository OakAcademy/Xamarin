using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoPlayerApp.Helpers;
using VideoPlayerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VideoPlayerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoListPage : ContentPage
    {
        public VideoListPage()
        {
            InitializeComponent();

            var helper = DependencyService.Get<IDeviceHelper>();

            var folderPath = helper.GetVideoFolder();
            var files = Directory.GetFiles(folderPath);

            List<VideoInfo> list = new List<VideoInfo>();

            foreach (var file in files)
            {
                list.Add(new VideoInfo
                {
                    Name = Path.GetFileName(file),
                    Path = file,
                    Duration = helper.GetVideoDuration(file),
                });
            }

            lstViewVideos.ItemsSource = list;
        }

        private void lstViewVideos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            var videoInfo = (VideoInfo)e.SelectedItem;
            Navigation.PushAsync(new VideoPlayerPage(videoInfo));
            lstViewVideos.SelectedItem = null;
        }
    }
}