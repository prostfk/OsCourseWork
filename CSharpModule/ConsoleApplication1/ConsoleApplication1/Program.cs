using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Run with parameter");
            }
            else
            {
                string requestUrl = "http://api.openweathermap.org/data/2.5/weather?q="
                                    + args[0] +
                                    "&appid=a94df725636c9b73d516e473151ba6b9";
                Console.WriteLine(new ApiUtil().GetJsonFromUrl(requestUrl));
            }
        }
    }
}