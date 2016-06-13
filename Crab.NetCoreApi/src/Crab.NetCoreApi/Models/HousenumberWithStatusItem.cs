namespace Crab.NetCoreApi.Models
{
    public class HousenumberWithStatusItem
    {
        public string Url => $"housenumbers/{HousenumberId}/withstatus";

        public int HousenumberId { get; set; }
        public string Housenumber { get; set; }
        public int StatusHousenumber { get; set; }

        public string WithoutStatus => $"housenumbers/{HousenumberId}";
        public string Postaladdress => $"housenumbers/{HousenumberId}/postaladdress";
        public string Postalcanton => $"housenumbers/{HousenumberId}/postalcanton";
        public string Addresspositions => $"housenumbers/{HousenumberId}/addresspositions";
        public string Buildings => $"housenumbers/{HousenumberId}/buildings";
        public string Parcels => $"housenumbers/{HousenumberId}/parcels";
        public string NationalregisterAddresses => $"housenumbers/{HousenumberId}/nationalregisteraddresses";
        public string Subaddresses => $"housenumbers/{HousenumberId}/subaddresses";
        public string SubaddressesWithstatus => $"housenumbers/{HousenumberId}/subaddresses/withstatus";
        public string Terrainobjects => $"housenumbers/{HousenumberId}/terrainobjects";
    }
}