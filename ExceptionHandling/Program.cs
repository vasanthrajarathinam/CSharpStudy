using System;

namespace ExceptionHandling
{
    class Program : YoutubeHelper
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public override void PayVideo()
        {
            try
            {
                throw new YoutubeExcepiton("test");

            }
            catch(YoutubeExcepiton ex)
            {
                Console.WriteLine("mesage thrown from youtube exception");
            }
        }
    }
}
