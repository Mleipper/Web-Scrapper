using System;
using System.Collections.Generic;
using System.Text;

namespace WebScrapper.StarSportsAPIFiles
{

    public class FeedData
    {
        public Event[] events { get; set; }
        public Market[] markets { get; set; }
        public Participant1[] participants { get; set; }
        public Selection[] selections { get; set; }
        public Competition[] competitions { get; set; }
        public Sport[] sports { get; set; }
        public Tags tags { get; set; }
        public int total { get; set; }
    }

    public class Tags
    {
        public string[] country { get; set; }
        public object[] region { get; set; }
    }

    public class Event
    {
        public int id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string sport { get; set; }
        public string competition { get; set; }
        public string template { get; set; }
        public string eventType { get; set; }
        public int displayOrder { get; set; }
        public bool active { get; set; }
        public bool display { get; set; }
        public bool cashoutAvailable { get; set; }
        public bool blockSettlement { get; set; }
        public bool autoTakeDown { get; set; }
        public bool antePost { get; set; }
        public Tags1 tags { get; set; }
        public Timesettings timeSettings { get; set; }
        public Feeddata feedData { get; set; }
        public Participant[] participants { get; set; }
        public Statistics statistics { get; set; }
        public int?[] markets { get; set; }
        public object[] marketIndex { get; set; }
    }

    public class Tags1
    {
        public string[] antepost { get; set; }
        public string[] country { get; set; }
        public string[] telebetquicklink { get; set; }
        public string[] starevents { get; set; }
    }

    public class Timesettings
    {
        public DateTime startTime { get; set; }
        public bool started { get; set; }
        public bool tradedInPlay { get; set; }
        public bool offAtStartTime { get; set; }
        public string timeZone { get; set; }
    }

    public class Feeddata
    {
        public string runners { get; set; }
        public string handicap { get; set; }
        public string courseType { get; set; }
        public string surface { get; set; }
        public string epoch { get; set; }
        public string feedId { get; set; }
        public string going { get; set; }
        public string progressMessage { get; set; }
        public string groupId { get; set; }
        public string trackCode { get; set; }
        public string eventStatus { get; set; }
        public string sequence { get; set; }
        public string meetingCode { get; set; }
        public string distance { get; set; }
    }

    public class Statistics
    {
    }

    public class Participant
    {
        public int id { get; set; }
        public object role { get; set; }
    }

    public class Market
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public bool autoTakeDown { get; set; }
        public bool display { get; set; }
        public int displayOrder { get; set; }
        public bool tradedInPlay { get; set; }
        public bool? forecastsOffered { get; set; }
        public bool? tricastsOffered { get; set; }
        public int inPlayDelay { get; set; }
        public bool sp { get; set; }
        public object line { get; set; }
        public bool cashoutAvailable { get; set; }
        public bool bp { get; set; }
        public bool bpApplicable { get; set; }
        public bool spApplicable { get; set; }
        public bool spOnly { get; set; }
        public object eachWayStakeReduction { get; set; }
        public object betReferralEnabled { get; set; }
        public int[] selections { get; set; }
        public object suspendTime { get; set; }
        public Event1 _event { get; set; }
        public Template template { get; set; }
        public Eachway eachWay { get; set; }
        public Tags2 tags { get; set; }
    }

    public class Event1
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Template
    {
        public string id { get; set; }
        public string eventTemplateId { get; set; }
        public string sportId { get; set; }
        public string name { get; set; }
    }

    public class Eachway
    {
        public bool offered { get; set; }
        public bool termsWithBet { get; set; }
        public Term[] terms { get; set; }
    }

    public class Term
    {
        public int places { get; set; }
        public string reduction { get; set; }
    }

    public class Tags2
    {
        public string[] marketgrouppopularmarkets { get; set; }
        public string[] marketgroupallmarkets { get; set; }
        public string[] marketgroupspecialmarkets { get; set; }
        public string[] websitemain { get; set; }
        public string[] antepost { get; set; }
        public string[] marketgroupracewinner { get; set; }
        public string[] displaytemplate { get; set; }
        public string[] grouptemplate { get; set; }
        public string[] marketgroupplacebetting { get; set; }
        public string[] telebetpopularmarket { get; set; }
        public string[] displayorder { get; set; }
        public string[] websitepopular { get; set; }
    }

    public class Participant1
    {
        public int id { get; set; }
        public string name { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public string silk { get; set; }
        public string silkUrl { get; set; }
        public string number { get; set; }
        public string weight { get; set; }
        public string drawn { get; set; }
        public string jockey { get; set; }
        public string trainer { get; set; }
        public string status { get; set; }
        public object place { get; set; }
    }

    public class Selection
    {
        public int id { get; set; }
        public Template1 template { get; set; }
        public string name { get; set; }
        public object[] participants { get; set; }
        public bool active { get; set; }
        public bool display { get; set; }
        public int displayOrder { get; set; }
        public Spprice spPrice { get; set; }
        public Pricehistory[] priceHistory { get; set; }
        public string state { get; set; }
        public bool blockSettlement { get; set; }
        public Result result { get; set; }
        public Tags3 tags { get; set; }
        public string priceType { get; set; }
        public Feedsettings feedSettings { get; set; }
        public Metadata1 metadata { get; set; }
        public Price price { get; set; }
    }

    public class Template1
    {
        public string id { get; set; }
        public string marketTemplateId { get; set; }
        public string eventTemplateId { get; set; }
        public string sportId { get; set; }
        public string name { get; set; }
    }

    public class Spprice
    {
        public float d { get; set; }
        public string f { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public Placereduction[] placeReductions { get; set; }
        public int place { get; set; }
    }

    public class Placereduction
    {
        public Eachwayterms eachWayTerms { get; set; }
    }

    public class Eachwayterms
    {
        public int places { get; set; }
        public string reduction { get; set; }
    }

    public class Tags3
    {
        public string[] priceboost { get; set; }
        public string[] pricewise { get; set; }
    }

    public class Feedsettings
    {
        public bool updates { get; set; }
        public bool prices { get; set; }
    }

    public class Metadata1
    {
        public string silk { get; set; }
        public string silkUrl { get; set; }
        public string number { get; set; }
        public string weight { get; set; }
        public string drawn { get; set; }
        public string jockey { get; set; }
        public string trainer { get; set; }
        public string status { get; set; }
        public object place { get; set; }
    }

    public class Price
    {
        public float d { get; set; }
        public string f { get; set; }
    }

    public class Pricehistory
    {
        public DateTime t { get; set; }
        public P p { get; set; }
    }

    public class P
    {
        public float d { get; set; }
        public string f { get; set; }
    }

    public class Competition
    {
        public string id { get; set; }
        public string name { get; set; }
        public string displayOrder { get; set; }
    }

    public class Sport
    {
        public string id { get; set; }
        public string name { get; set; }
    }

}
