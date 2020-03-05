using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayerApp.Models
{
    public class VideoInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
