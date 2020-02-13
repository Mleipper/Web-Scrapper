namespace WebScrapper.NewFolder
{
    public class Selection
    {
        public int Id { get; set; }
        public Template1 Template { get; set; }
        public string Name { get; set; }
        public object[] Participants { get; set; }
        public bool Active { get; set; }
        public bool Display { get; set; }
        public int DisplayOrder { get; set; }
        public Spprice SpPrice { get; set; }
        public Pricehistory[] PriceHistory { get; set; }
        public string State { get; set; }
        public bool BlockSettlement { get; set; }
        public Result Result { get; set; }
        public Tags3 Tags { get; set; }
        public string PriceType { get; set; }
        public Feedsettings FeedSettings { get; set; }
        public Metadata1 Metadata { get; set; }
        public Price Price { get; set; }
    }


}
