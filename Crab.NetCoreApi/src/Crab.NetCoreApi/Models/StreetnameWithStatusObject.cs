using System;

namespace Crab.NetCoreApi.Models
{
    public class StreetnameWithStatusObject
    {
        public string Url => $"streetnames/{StreetnameId}/withstatus";

        public int CommuneId { get; set; }
        public int StreetnameId { get; set; }
        public string Streetname { get; set; }
        public string Streetname2 { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public string StreetnameLabel { get; set; }
        public int StatusStreetname { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public int StartExploitation { get; set; }
        public int StartOrganisation { get; set; }

        public string Commune => $"communes/{CommuneId}";
        public string Housenumbers => $"streetnames/{StreetnameId}/housenumbers";
        public string HousenumbersWithstatus => $"streetnames/{StreetnameId}/housenumbers/withstatus";
        public string Roadobjects => $"streetnames/{StreetnameId}/roadobjects";
        public string Roadsegments => $"streetnames/{StreetnameId}/roadsegments";
        public string Postaladdresses => $"streetnames/{StreetnameId}/postaladdresses";
    }
}