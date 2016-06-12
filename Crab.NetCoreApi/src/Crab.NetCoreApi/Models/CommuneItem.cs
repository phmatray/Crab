namespace Crab.NetCoreApi.Models
{
    public class CommuneItem
    {
        public string Url => $"/communes/{CommuneId}/";
        public string Description => "...";

        public int CommuneId { get; set; }
        public string CommuneName { get; set; }
        public string CommuneNameLanguageCode { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public int CommuneNISCode { get; set; }

        public string Postalcantons => $"/communes/{CommuneId}/postalcantons/";
        public string Streetnames => $"/communes/{CommuneId}/streetnames/";
        public string StreetnamesWithStatus => $"/communes/{CommuneId}/streetnames/withstatus/";
    }
}
