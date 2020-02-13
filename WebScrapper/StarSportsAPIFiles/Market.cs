namespace WebScrapper.NewFolder
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public bool AutoTakeDown { get; set; }
        public bool Display { get; set; }
        public int DisplayOrder { get; set; }
        public bool TradedInPlay { get; set; }
        public bool ForecastsOffered { get; set; }
        public bool TricastsOffered { get; set; }
        public int InPlayDelay { get; set; }
        public bool Sp { get; set; }
        public object Line { get; set; }
        public bool CashoutAvailable { get; set; }
        public bool Bp { get; set; }
        public bool BpApplicable { get; set; }
        public bool SpApplicable { get; set; }
        public bool SpOnly { get; set; }
        public object EachWayStakeReduction { get; set; }
        public object BetReferralEnabled { get; set; }
        public int[] Selections { get; set; }
        public object SuspendTime { get; set; }
        public Event1 _event { get; set; }
        public Template Template { get; set; }
        public Eachway EachWay { get; set; }
        public Tags2 Tags { get; set; }
    }


}
