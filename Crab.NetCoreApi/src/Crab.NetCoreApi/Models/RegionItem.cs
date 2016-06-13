namespace Crab.NetCoreApi.Models
{
    public class RegionItem
    {
        public string Url => $"/regions/{RegionId}/";

        public int RegionId { get; set; }
        public string RegionNameLanguageCode { get; set; }
        public string RegionName { get; set; }

        public string UrlCommunes => $"/regions/{RegionId}/communes/";
    }
}