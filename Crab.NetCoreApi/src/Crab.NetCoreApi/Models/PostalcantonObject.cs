using System;

namespace Crab.NetCoreApi.Models
{
    public class PostalcantonObject
    {
        public int PostalcantonId { get; set; }
        public int PostalcantonCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}