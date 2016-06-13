using System;

namespace Crab.NetCoreApi.Models
{
    public class RegionObject
    {
        public string Url => $"/regions/{RegionId}/";

        public int RegionId { get; set; }
        public string RegionNameLanguageCode { get; set; }
        public string RegionName { get; set; }
        public decimal CenterX { get; set; }
        public decimal CenterY { get; set; }
        public decimal MinimumX { get; set; }
        public decimal MinimumY { get; set; }
        public decimal MaximumX { get; set; }
        public decimal MaximumY { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }

        public string UrlCommunes => $"/regions/{RegionId}/communes/";
    }
}