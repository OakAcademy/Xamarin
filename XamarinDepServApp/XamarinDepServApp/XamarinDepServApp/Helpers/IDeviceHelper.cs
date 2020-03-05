using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinDepServApp.Helpers
{
    public interface IDeviceHelper
    {
        string GetPlatformName();
        Size GetScreenSize();
    }
}
