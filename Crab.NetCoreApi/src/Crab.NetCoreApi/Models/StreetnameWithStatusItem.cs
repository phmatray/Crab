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

        public string Housenumbers => $"streetnames/{StreetnameId}/housenumbers";
        public string HousenumbersWithstatus => $"streetnames/{StreetnameId}/housenumbers/withstatus";
        public string Roadobjects => $"streetnames/{StreetnameId}/roadobjects";
        public string Roadsegments => $"streetnames/{StreetnameId}/roadsegments";
        public string Postaladdresses => $"streetnames/{StreetnameId}/postaladdresses";
    }
}