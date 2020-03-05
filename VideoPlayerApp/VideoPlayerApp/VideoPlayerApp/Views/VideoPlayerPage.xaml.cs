using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoPlayerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VideoPlayerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPlayerPage : ContentPage
    {
        VideoInfo videoInfo;
        public VideoPlayerPage(VideoInfo videoInfo)
        {
            InitializeComponent();

            this.videoInfo = videoInfo;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            videoPlayer.Source = videoInfo.Path;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (videoPlayer.Status == CustomControls.PlayerStatus.Playing) videoPlayer.Pause();
            else videoPlayer.Play();
        }
    }
}