namespace Crab.NetCoreApi.Models
{
    public class StreetnameWithStatusItem
    {
        public string Url => $"streetnames/{StreetnameId}/withstatus";

        public int StreetnameId { get; set; }
        public string Streetname { get; set; }
        public string Streetname2 { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageCode2 { get; set; }
        public string StreetnameLabel { get; set; }
        public int StatusStreetname { get; set; }

        public string UrlWithoutStatus => $"streetnames/{StreetnameId}";
        public string UrlHousenumbers => $"streetnames/{StreetnameId}/housenumbers";
        public string UrlHousenumbersWithstatus => $"streetnames/{StreetnameId}/housenumbers/withstatus";
        public string UrlRoadobjects => $"streetnames/{StreetnameId}/roadobjects";
        public string UrlRoadsegments => $"streetnames/{StreetnameId}/roadsegments";
        public string UrlPostaladdresses => $"streetnames/{StreetnameId}/postaladdresses";
        public string UrlNationalregisterstreets => $"streetnames/{StreetnameId}/nationalregisterstreets";
        public string UrlAddresstypes => $"streetnames/{StreetnameId}/addresstypes";
    }
}