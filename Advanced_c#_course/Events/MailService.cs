using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine("MailService: sending an email to " + e.Video.Title);
        }
    }
}
