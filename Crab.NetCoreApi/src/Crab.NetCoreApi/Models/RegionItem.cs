namespace Crab.NetCoreApi.Models
{
    public class RegionItem
    {
        public string Url => $"/regions/{Id}/";
        public string Description => "...";

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameLanguageCode { get; set; }

        public string Communes => $"/regions/{Id}/communes/";
    }
}