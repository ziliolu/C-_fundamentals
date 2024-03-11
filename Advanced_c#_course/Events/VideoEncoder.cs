using System;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        /* 1 - define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        
        2 - define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        podemos usar um delegate padrao ja existente em c#  */
        public event EventHandler<VideoEventArgs> VideoEncoded;

       /*  for a generic form instead of different args 
        such as VideoEventArgs we can simply declare like: 
                public event EventHandler VideoEncoded; */

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding video...");
            System.Console.WriteLine(video.Title);
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // 3 - raise the event
        protected virtual void OnVideoEncoded(Video video)
        {

            // 1. check if there are subscribers to the event
            if(VideoEncoded != null)
            {
                // 2. notify subscribers
                VideoEncoded(this, new VideoEventArgs(){Video = video});
            }
        }
    }
}
