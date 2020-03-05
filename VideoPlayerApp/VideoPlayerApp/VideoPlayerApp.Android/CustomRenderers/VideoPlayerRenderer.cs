using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VideoPlayerApp.CustomControls;
using VideoPlayerApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using RelativeLayout = Android.Widget.RelativeLayout;

[assembly: ExportRenderer(typeof(VideoPlayer), typeof(VideoPlayerRenderer))]
namespace VideoPlayerApp.Droid.CustomRenderers
{
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, RelativeLayout>
    {
        public VideoPlayerRenderer(Context context) : base(context)
        {
        }

        VideoView videoView;
        System.Timers.Timer timer = new System.Timers.Timer(100);

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null) return;

            videoView = new VideoView(Context);
            RelativeLayout relativeLayout = new RelativeLayout(Context);
            relativeLayout.AddView(videoView);

            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            layoutParams.AddRule(LayoutRules.CenterInParent);
            videoView.LayoutParameters = layoutParams;

            SetNativeControl(relativeLayout);

            videoView.Prepared += VideoView_Prepared;

            e.NewElement.PlayRequest += NewElement_PlayRequest;
            e.NewElement.PauseRequest += NewElement_PauseRequest;

            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (videoView.IsPlaying) Element.Position = TimeSpan.FromMilliseconds(videoView.CurrentPosition);
        }

        private void NewElement_PauseRequest(object sender, EventArgs e)
        {
            videoView.Pause();
            timer.Stop();
        }

        private void NewElement_PlayRequest(object sender, EventArgs e)
        {
            timer.Start();
            videoView.Start();
        }

        private void VideoView_Prepared(object sender, EventArgs e)
        {
            Element.Duration = TimeSpan.FromMilliseconds(videoView.Duration);
            timer.Enabled = true;
            videoView.Start();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == VideoPlayer.SourceProperty.PropertyName)
            {
                if (!string.IsNullOrEmpty(Element.Source)) videoView.SetVideoPath(Element.Source);
            }

            else if (e.PropertyName == VideoPlayer.PositionProperty.PropertyName)
            {
                if (Math.Abs(videoView.CurrentPosition - Element.Position.TotalMilliseconds) > 1000)
                {
                    videoView.SeekTo((int)Element.Position.TotalMilliseconds);
                }
            }
        }
    }
}