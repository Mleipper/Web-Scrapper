using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebScrapper
{
    class WebScrapper
    {
        private readonly string BaseUri = "https://starsports.bet/sport/horseracing";

        private readonly string test = "https://www.starsports.bet/api/events/search?market.main=yes&perPage=500&sort=-competition.displayOrder&sort=competition.name&sort=timeSettings.startTime&sport=horseracing&startTime%5Bfrom%5D=2020-02-13T00%3A00%3A00.000Z&startTime%5Bto%5D=2020-02-15T00%3A00%3A00.000Z&tags.star-events=-";

        public async Task<IHtmlDocument> GetRespone()
        {
            var httpClient = new HttpClient();

            var request = await httpClient.GetAsync(BaseUri);

            Stream response = await request.Content.ReadAsStreamAsync();

            var parser = new HtmlParser();

            return parser.ParseDocument(response);

        }

        public string GetDateFromAndTo()
        {
            var currentDateTime = DateTime.UtcNow;

            return $"from%5D=2020-02-13T00%3A00%3A00.000Z&startTime%5Bto%5D=2020-02-15T00%3A00%3A00.000Z";
        }

        public void GetScrapeResults(IHtmlDocument document)
        {
            IEnumerable<IElement> articleLink;


            articleLink = document.All.Where(x => x.ClassName == "races-slider__races-slide");


            if (articleLink.Any())
            {
                Console.WriteLine(articleLink);
            }
        }

        //class="races-slider__races-slide"
    }
}
