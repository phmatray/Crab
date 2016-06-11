namespace Crab.NetCoreApi.Models
{
    public class CommuneItem
    {
        public string Url => $"/regions/{Id}/communes/";
        public string Description => "...";

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameLanguageCode { get; set; }
        public string LanguageCode1 { get; set; }
        public string LanguageCode2 { get; set; }
        public int NISCommuneCode { get; set; }
    }
}