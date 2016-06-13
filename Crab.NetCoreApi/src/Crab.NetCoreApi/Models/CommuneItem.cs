namespace Crab.NetCoreApi.Models
{
    public class CommuneItem
    {
        public string Url => $"/communes/{CommuneId}/";
        public string UrlByNisCode => $"/communes/niscode/{CommuneNISCode}/";

        public int CommuneId { get; set; }
        public string CommuneName { get; set; }
        public string CommuneNameLanguageCode { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public int CommuneNISCode { get; set; }

        public string UrlPostalcantons => $"/communes/{CommuneId}/postalcantons/";
        public string UrlStreetnames => $"/communes/{CommuneId}/streetnames/";
        public string UrlStreetnamesWithStatus => $"/communes/{CommuneId}/streetnames/withstatus/";
    }
}
