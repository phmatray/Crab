using System;

namespace Crab.NetCoreApi.Models
{
    public class NationalregisterstreetObject
    {
        public string Url => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/";

        public int StreetCode { get; set; }
        public int SubcantonCode { get; set; }
        public string Streetname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }

        public string UrlStreetname => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/streetname/";
        public string UrlStreetnameWithstatus => $"/nationalregisterstreets/{StreetCode},{SubcantonCode}/streetname/withstatus/";
    }
}