using System;

namespace Crab.NetCoreApi.Models
{
    public class CommuneObject
    {
        public string Url => $"/communes/{Id}/";
        public string Description => "...";

        public int RegionId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameLanguageCode { get; set; }
        public string LanguageCode1 { get; set; }
        public string LanguageCode2 { get; set; }
        public int NISCommuneCode { get; set; }
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

        public string Region => $"/regions/{RegionId}/";
    }
}