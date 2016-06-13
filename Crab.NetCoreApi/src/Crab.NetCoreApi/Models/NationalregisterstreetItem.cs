namespace Crab.NetCoreApi.Models
{
    public class NationalregisterstreetItem
    {
        public string Url => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/";

        public int StreetCode { get; set; }
        public int SubcantonCode { get; set; }

        public string UrlStreetname => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/streetname/";
        public string UrlStreetnameWithstatus => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/streetname/withstatus/";
    }
}