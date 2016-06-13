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

        public string UrlCommune => $"communes/{CommuneId}";
        public string UrlWithStatus => $"streetnames/{StreetnameId}/withstatus";
        public string UrlHousenumbers => $"streetnames/{StreetnameId}/housenumbers";
        public string UrlHousenumbersWithstatus => $"streetnames/{StreetnameId}/housenumbers/withstatus";
        public string UrlRoadobjects => $"streetnames/{StreetnameId}/roadobjects";
        public string UrlRoadsegments => $"streetnames/{StreetnameId}/roadsegments";
        public string UrlPostaladdresses => $"streetnames/{StreetnameId}/postaladdresses";
        public string UrlNationalregisterstreets => $"streetnames/{StreetnameId}/nationalregisterstreets";
        public string UrlAddresstypes => $"streetnames/{StreetnameId}/addresstypes";
    }
}