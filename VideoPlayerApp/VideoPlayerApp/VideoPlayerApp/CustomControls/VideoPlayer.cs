using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VideoPlayerApp.CustomControls
{
    public class VideoPlayer : View
    {
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Source), typeof(string), typeof(VideoPlayer));

        public string Source
        {
            get => (string)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }


        public static readonly BindableProperty StatusProperty =
            BindableProperty.Create(nameof(Status), typeof(PlayerStatus), typeof(VideoPlayer), PlayerStatus.Playing);
        public PlayerStatus Status
        {
            get => (PlayerStatus)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        public event EventHandler PlayRequest;
        public void Play()
        {
            Status = PlayerStatus.Playing;
            PlayRequest?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler PauseRequest;
        public void Pause()
        {
            Status = PlayerStatus.Paused;
            PauseRequest?.Invoke(this, EventArgs.Empty);
        }


        public static readonly BindableProperty PositionProperty=
            BindableProperty.Create(nameof(Position), typeof(TimeSpan), typeof(VideoPlayer));
        public TimeSpan Position 
        { 
            get=>(TimeSpan)GetValue(PositionProperty); 
            set=>SetValue(PositionProperty, value); 
        }

        public static readonly BindableProperty DurationProperty =
            BindableProperty.Create(nameof(Duration), typeof(TimeSpan), typeof(VideoPlayer));
        public TimeSpan Duration
        {
            get => (TimeSpan)GetValue(DurationProperty);
            set => SetValue(DurationProperty, value);
        }
    }
}
