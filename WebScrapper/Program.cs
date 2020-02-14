using System;

namespace WebScrapper
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var scrapper = new StarSportJsonGetter();
            scrapper.GetDateFromAndTo();
            var response = await scrapper.GetResponeAsync();
            scrapper.GetScrapeResults(response);
        }
    }
}
