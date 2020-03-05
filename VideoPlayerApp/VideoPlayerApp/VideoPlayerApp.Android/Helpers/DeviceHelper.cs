using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VideoPlayerApp.Droid.Helpers;
using VideoPlayerApp.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceHelper))]
namespace VideoPlayerApp.Droid.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public TimeSpan GetVideoDuration(string path)
        {
            MediaMetadataRetriever retriever = new MediaMetadataRetriever();
            retriever.SetDataSource(path);
            var duration = retriever.ExtractMetadata(MetadataKey.Duration);
            double durationMillisec = Convert.ToDouble(duration);
            retriever.Dispose();
            return TimeSpan.FromMilliseconds(durationMillisec);
        }

        public string GetVideoFolder()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath;
        }
    }
}