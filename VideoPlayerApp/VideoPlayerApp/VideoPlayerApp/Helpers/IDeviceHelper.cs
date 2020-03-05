using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayerApp.Helpers
{
    public interface IDeviceHelper
    {
        string GetVideoFolder();
        TimeSpan GetVideoDuration(string path);
    }
}
