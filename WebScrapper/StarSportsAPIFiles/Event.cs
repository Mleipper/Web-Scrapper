namespace WebScrapper.NewFolder
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public string Sport { get; set; }
        public string Competition { get; set; }
        public string Template { get; set; }
        public string EventType { get; set; }
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
        public bool Display { get; set; }
        public bool CashoutAvailable { get; set; }
        public bool BlockSettlement { get; set; }
        public bool AutoTakeDown { get; set; }
        public bool AntePost { get; set; }
        public Tags1 Tags { get; set; }
        public Timesettings TimeSettings { get; set; }
        public Feeddata FeedData { get; set; }
        public Participant[] Participants { get; set; }
        public Statistics Statistics { get; set; }
        public int?[] Markets { get; set; }
        public object[] MarketIndex { get; set; }
    }


}
