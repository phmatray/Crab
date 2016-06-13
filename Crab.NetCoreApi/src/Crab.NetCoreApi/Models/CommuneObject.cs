using System;

namespace Crab.NetCoreApi.Models
{
    public class CommuneObject
    {
        public string Url => $"/communes/{CommuneId}/";
        public string UrlByNisCode => $"/communes/niscode/{CommuneNISCode}/";

        public int RegionId { get; set; }
        public int CommuneId { get; set; }
        public string CommuneName { get; set; }
        public string CommuneNameLanguageCode { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public int CommuneNISCode { get; set; }
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

        public string UrlPostalcantons => $"/communes/{CommuneId}/postalcantons/";
        public string UrlStreetnames => $"/communes/{CommuneId}/streetnames/";
        public string UrlStreetnamesWithStatus => $"/communes/{CommuneId}/streetnames/withstatus/";
    }
}