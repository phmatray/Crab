using System;

namespace Crab.NetCoreApi.Models
{
    public class HousenumberWithStatusObject
    {
        public int StreetnameId { get; set; }
        public int HousenumberId { get; set; }
        public string Housenumber { get; set; }
        public int StatusHousenumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}