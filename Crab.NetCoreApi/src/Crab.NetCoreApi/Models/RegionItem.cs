namespace Crab.NetCoreApi.Models
{
    public class RegionItem
    {
        public string Url => $"/regions/{RegionId}/";
        public string Description => "...";

        public int RegionId { get; set; }
        public string RegionNameLanguageCode { get; set; }
        public string RegionName { get; set; }

        public string Communes => $"/regions/{RegionId}/communes/";
    }
}