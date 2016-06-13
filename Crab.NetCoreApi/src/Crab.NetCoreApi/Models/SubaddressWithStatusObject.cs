using System;

namespace Crab.NetCoreApi.Models
{
    public class SubaddressWithStatusObject
    {
        public string Url => $"subaddresses/{SubaddressId}/withstatus";

        public int HousenumberId { get; set; }
        public int SubaddressId { get; set; }
        public string Subaddress { get; set; }
        public int SubaddressType { get; set; }
        public int StatusSubaddress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }

        public string WithoutStatus => $"subaddresses/{SubaddressId}";
        public string Postaladdress => $"subaddresses/{SubaddressId}/postaladdress";
        public string Addresspositions => $"subaddresses/{SubaddressId}/addresspositions";
        public string Nationalregisteraddresses => $"subaddresses/{SubaddressId}/nationalregisteraddresses";
    }
}