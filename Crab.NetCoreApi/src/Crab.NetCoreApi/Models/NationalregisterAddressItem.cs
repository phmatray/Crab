namespace Crab.NetCoreApi.Models
{
    public class NationalregisterAddressItem
    {
        public int NationalregisterAddressId { get; set; }
        public string Housenumber { get; set; }
        public string Index { get; set; }
        public int StreetCode { get; set; }
        public int SubcantonCode { get; set; }

        string UrlHousenumbersWithstatus => $"nationalregisteraddresses/{NationalregisterAddressId}/housenumbers/withstatus";
        string UrlSubaddressesWithstatus => $"nationalregisteraddresses/{NationalregisterAddressId}/housenumbers/withstatus";
    }
}