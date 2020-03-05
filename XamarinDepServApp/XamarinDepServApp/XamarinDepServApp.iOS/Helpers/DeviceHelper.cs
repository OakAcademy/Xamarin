using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinDepServApp.Helpers;
using XamarinDepServApp.iOS.Helpers;

[assembly: Dependency(typeof(DeviceHelper))]
namespace XamarinDepServApp.iOS.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetPlatformName()
        {
            return "iOS";
        }

        public Size GetScreenSize()
        {
            var width = UIScreen.MainScreen.Bounds.Width;
            var height = UIScreen.MainScreen.Bounds.Height;

            return new Size(width, height);
        }
    }
}