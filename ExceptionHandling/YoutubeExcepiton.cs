using System;

namespace ExceptionHandling
{
    public class YoutubeExcepiton : Exception
    {
        public YoutubeExcepiton(string message)
            :base(message)
        {

        }
        public YoutubeExcepiton(string message, Exception innerException) : base(message,innerException)
        {

        }
    }
}
