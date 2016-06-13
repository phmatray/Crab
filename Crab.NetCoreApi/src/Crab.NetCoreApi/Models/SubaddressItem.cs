namespace Crab.NetCoreApi.Models
{
    public class SubaddressItem
    {
        public string Url => $"subaddresses/{SubaddressId}";

        public int SubaddressId { get; set; }
        public string Subaddress { get; set; }

        public string WithStatus => $"subaddresses/{SubaddressId}/withstatus";
        public string Postaladdress => $"subaddresses/{SubaddressId}/postaladdress";
        public string Addresspositions => $"subaddresses/{SubaddressId}/addresspositions";
        public string Nationalregisteraddresses => $"subaddresses/{SubaddressId}/nationalregisteraddresses";
    }
}