using System;

namespace WebScrapper
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var scrapper = new WebScrapper();

            var response = await scrapper.GetRespone();
            scrapper.GetScrapeResults(response);
        }
    }
}
