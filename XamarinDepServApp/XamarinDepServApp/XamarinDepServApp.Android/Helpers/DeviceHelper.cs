using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinDepServApp.Droid.Helpers;
using XamarinDepServApp.Helpers;

[assembly: Dependency(typeof(DeviceHelper))]
namespace XamarinDepServApp.Droid.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetPlatformName()
        {
            return "Android";
        }

        public Size GetScreenSize()
        {
            var displayMetrics = Resources.System.DisplayMetrics;

            var width = displayMetrics.WidthPixels / displayMetrics.Density;
            var height = displayMetrics.HeightPixels / displayMetrics.Density;

            return new Size(width, height);
        }
    }
}