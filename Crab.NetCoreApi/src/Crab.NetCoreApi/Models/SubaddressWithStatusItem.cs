namespace Crab.NetCoreApi.Models
{
    public class SubaddressWithStatusItem
    {
        public string Url => $"subaddresses/{SubaddressId}/withstatus";
        
        public int SubaddressId { get; set; }
        public string Subaddress { get; set; }
        public int StatusSubaddress { get; set; }

        public string UrlWithoutStatus => $"subaddresses/{SubaddressId}";
        public string UrlPostaladdress => $"subaddresses/{SubaddressId}/postaladdress";
        public string UrlAddresspositions => $"subaddresses/{SubaddressId}/addresspositions";
        public string UrlNationalregisteraddresses => $"subaddresses/{SubaddressId}/nationalregisteraddresses";
    }
}