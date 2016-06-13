using System;

namespace Crab.NetCoreApi.Models
{
    public class StreetnameObject
    {
        public string Url => $"streetnames/{StreetnameId}";

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

        public string Commune => $"communes/{CommuneId}";

        public string WithStatus => $"streetnames/{StreetnameId}/withstatus";
        public string Housenumbers => $"streetnames/{StreetnameId}/housenumbers";
        public string HousenumbersWithstatus => $"streetnames/{StreetnameId}/housenumbers/withstatus";
        public string Roadobjects => $"streetnames/{StreetnameId}/roadobjects";
        public string Roadsegments => $"streetnames/{StreetnameId}/roadsegments";
        public string Postaladdresses => $"streetnames/{StreetnameId}/postaladdresses";
        public string Nationalregisterstreets => $"streetnames/{StreetnameId}/nationalregisterstreets";
        public string Addresstypes => $"streetnames/{StreetnameId}/addresstypes";
    }
}