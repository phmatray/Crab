using System;

namespace Crab.NetCoreApi.Models
{
    public class RoadsegmentObject
    {
        public string RoadsegmentId { get; set; }
        public int StatusRoadsegment { get; set; }
        public int GeometrymethodRoadsegment { get; set; }
        public string Geometry { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}