using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_events.lib
{
    public class VideoEncode
    {
        //public delegate void VideoEncodedHandle(Video video);
        //public event VideoEncodedHandle Encoded;

        public event EventHandler<VideoEventsArgs> Encoded;
        public void Encode(Video video) 
        {
            Console.WriteLine("Convertendo o video...");
            Thread.Sleep(3000);
            Console.WriteLine("Video convertido.");

            Encoded(null, new VideoEventsArgs { Video = video });
        }
    }

    public class VideoEventsArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
