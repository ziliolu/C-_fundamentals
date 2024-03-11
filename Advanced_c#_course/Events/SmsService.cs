using System;

namespace Events
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("SmsService: sending a SMS to " + e.Video.Title);
        }
    }
}
