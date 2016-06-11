using System;

namespace Crab.NetCoreApi.Models
{
    public class ParcelObject
    {
        public string ParcelId { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}