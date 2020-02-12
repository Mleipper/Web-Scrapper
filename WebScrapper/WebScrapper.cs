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
        private readonly string uri = "https://starsports.bet/sport/horseracing";

        public async Task<IHtmlDocument> GetRespone()
        {
            var httpClient = new HttpClient();

            var request = await httpClient.GetAsync(uri);

            Stream response = await request.Content.ReadAsStreamAsync();

            var parser = new HtmlParser();

            return parser.ParseDocument(response);

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
