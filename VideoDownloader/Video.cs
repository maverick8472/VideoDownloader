using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Downloader
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Url { get; set; }
        public float Size { get; set; }
        public Image Thumbnail { get; set; }
        public string Duration { get; internal set; }
        public string Location { get; set; }

    }
}
