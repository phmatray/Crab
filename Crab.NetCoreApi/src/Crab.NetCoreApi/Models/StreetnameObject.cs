using System;

namespace Crab.NetCoreApi.Models
{
    public class StreetnameObject
    {
        public int CommuneId { get; set; }
        public int StreetnameId { get; set; }
        public string Streetname { get; set; }
        public string Streetname2 { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public string StreetnameLabel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }
    }
}