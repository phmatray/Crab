namespace Crab.NetCoreApi.Models
{
    public class AddresspositionItem
    {
        public string Url => $"addresspositions/{AddresspositionId}/";

        public int AddresspositionId { get; set; }
        public int AddresspositionProvenance { get; set; }
    }
}