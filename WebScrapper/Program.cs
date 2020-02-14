using System;

namespace WebScrapper
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var scrapper = new StarSportJsonGetter();
            scrapper.GetEndPoint();
            var response = await scrapper.GetResponeAsync();
        }
    }
}
