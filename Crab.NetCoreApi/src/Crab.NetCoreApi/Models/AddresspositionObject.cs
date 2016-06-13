using System;

namespace Crab.NetCoreApi.Models
{
    public class AddresspositionObject
    {
        public string Url => $"addresspositions/{AddresspositionId}/";

        public int AddresspositionId { get; set; }
        public int AddresspositionProvenance { get; set; }
        public string Geometry { get; set; }
        public int AddressType { get; set; }
        public int AddressId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}