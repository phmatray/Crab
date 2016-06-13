namespace Crab.NetCoreApi.Models
{
    public class SubaddressWithStatusItem
    {
        public string Url => $"subaddresses/{SubaddressId}/withstatus";
        
        public int SubaddressId { get; set; }
        public string Subaddress { get; set; }
        public int StatusSubaddress { get; set; }

        public string WithoutStatus => $"subaddresses/{SubaddressId}";
        public string Postaladdress => $"subaddresses/{SubaddressId}/postaladdress";
        public string Addresspositions => $"subaddresses/{SubaddressId}/addresspositions";
        public string Nationalregisteraddresses => $"subaddresses/{SubaddressId}/nationalregisteraddresses";
    }
}