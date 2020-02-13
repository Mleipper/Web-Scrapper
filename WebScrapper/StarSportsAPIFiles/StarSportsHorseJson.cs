using System.Collections.Generic;
using System.Text;

namespace WebScrapper.NewFolder
{
    public class StarSportsHorseJson
    {
        public Event[] Events { get; set; }
        public Market[] Markets { get; set; }
        public Participant1[] Participants { get; set; }
        public Selection[] Selections { get; set; }
        public Competition[] Competitions { get; set; }
        public Sport[] Sports { get; set; }
        public Tags Tags { get; set; }
        public int Total { get; set; }
    }
}
