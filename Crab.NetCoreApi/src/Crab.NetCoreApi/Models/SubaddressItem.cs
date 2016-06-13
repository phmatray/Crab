namespace Crab.NetCoreApi.Models
{
    public class SubaddressItem
    {
        public string Url => $"subaddresses/{SubaddressId}";

        public int SubaddressId { get; set; }
        public string Subaddress { get; set; }

        public string UrlWithStatus => $"subaddresses/{SubaddressId}/withstatus";
        public string UrlPostaladdress => $"subaddresses/{SubaddressId}/postaladdress";
        public string UrlAddresspositions => $"subaddresses/{SubaddressId}/addresspositions";
        public string UrlNationalregisteraddresses => $"subaddresses/{SubaddressId}/nationalregisteraddresses";
    }
}