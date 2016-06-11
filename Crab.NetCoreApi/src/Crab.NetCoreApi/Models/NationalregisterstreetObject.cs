using System;

namespace Crab.NetCoreApi.Models
{
    public class NationalregisterstreetObject
    {
        public int StreetCode { get; set; }
        public int SubcantonCode { get; set; }
        public string Streetname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}