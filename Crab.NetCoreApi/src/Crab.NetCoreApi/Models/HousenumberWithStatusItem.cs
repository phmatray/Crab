namespace Crab.NetCoreApi.Models
{
    public class HousenumberWithStatusItem
    {
        public string Url => $"housenumbers/{HousenumberId}/withstatus";

        public int HousenumberId { get; set; }
        public string Housenumber { get; set; }
        public int StatusHousenumber { get; set; }

        public string UrlWithoutStatus => $"housenumbers/{HousenumberId}";
        public string UrlPostaladdress => $"housenumbers/{HousenumberId}/postaladdress";
        public string UrlPostalcanton => $"housenumbers/{HousenumberId}/postalcanton";
        public string UrlAddresspositions => $"housenumbers/{HousenumberId}/addresspositions";
        public string UrlBuildings => $"housenumbers/{HousenumberId}/buildings";
        public string UrlParcels => $"housenumbers/{HousenumberId}/parcels";
        public string UrlNationalregisterAddresses => $"housenumbers/{HousenumberId}/nationalregisteraddresses";
        public string UrlSubaddresses => $"housenumbers/{HousenumberId}/subaddresses";
        public string UrlSubaddressesWithstatus => $"housenumbers/{HousenumberId}/subaddresses/withstatus";
        public string UrlTerrainobjects => $"housenumbers/{HousenumberId}/terrainobjects";
    }
}