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
using System.Web;

namespace WebScrapper
{
    class StarSportJsonGetter
    {
        private HttpClient client;
        private readonly string BaseUri = "https://starsports.bet";

        private readonly string test = "https://www.starsports.bet/api/events/search?market.main=yes&perPage=500&sort=-competition.displayOrder&sort=competition.name&sort=timeSettings.startTime&sport=horseracing&startTime%5Bfrom%5D=2020-02-13T00%3A00%3A00.000Z&startTime%5Bto%5D=2020-02-15T00%3A00%3A00.000Z&tags.star-events=-";
        //https://www.starsports.bet/api/events/search?market.main=yes&perPage=500&sort=-competition.displayOrder&sort=competition.name&sort=timeSettings.startTime&sport=horseracing&startTime%5Bfrom%5D=13%2f02%2f2020+17%3a37%3a19&startTime%5Bto%5D=2020-02-15T00%3A00%3A00.000Z&tags.star-events=-
        
        public StarSportJsonGetter()
        {
            client = new HttpClient();
        }

        public async Task<IHtmlDocument> GetResponeAsync()
        {
            var request = await client.GetAsync(GetDateFromAndTo());

            if (!request.IsSuccessStatusCode)
            {
                throw new Exception($"Request for data failed with code {request.StatusCode}...");
            }

            string hhed = await request.Content.ReadAsStringAsync();

            Stream response = await request.Content.ReadAsStreamAsync();

            var parser = new HtmlParser();

            return parser.ParseDocument(response);

        }

        public string GetDateFromAndTo()
        {
            var currentDateTime = DateTime.UtcNow;

            var startTimeFrom = currentDateTime.AddMinutes(-10).ToString("yyyy-MM-ddTHH:mm:00.000Z");

            var startTimeTo = currentDateTime.AddDays(3).ToString("yyyy-MM-ddTHH:mm:00.000Z");

            return $"{BaseUri}/api/events/search?market.main=yes&perPage=500&sort=-competition.displayOrder&sort=competition.name&sort=timeSettings.startTime&sport=horseracing&startTime[from]={startTimeFrom}&startTime[to]={startTimeTo}&tags.star-events=-";
        }

        public string GetSport(int sport)
        {
            return "horseracing";
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
