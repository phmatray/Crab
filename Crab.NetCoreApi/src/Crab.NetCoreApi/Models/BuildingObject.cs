using System;

namespace Crab.NetCoreApi.Models
{
    public class BuildingObject
    {
        public string BuildingId { get; set; }
        public int BuildingType { get; set; }
        public int StatusBuilding { get; set; }
        public int GeometrymethodBuilding { get; set; }
        public string Geometry { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}