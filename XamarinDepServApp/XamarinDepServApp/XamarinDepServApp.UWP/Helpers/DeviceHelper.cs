using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms;
using XamarinDepServApp.Helpers;
using XamarinDepServApp.UWP.Helpers;

[assembly: Dependency(typeof(DeviceHelper))]
namespace XamarinDepServApp.UWP.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetPlatformName()
        {
            return "UWP";
        }

        public Size GetScreenSize()
        {
            var width = Window.Current.Bounds.Width;
            var height = Window.Current.Bounds.Height;

            return new Size(width, height);
        }
    }
}
