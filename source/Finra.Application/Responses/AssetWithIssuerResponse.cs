namespace Finra.Application.Responses
{
    public class AssetWithIssuerResponse
    {
        public string Country { get; set; }
        public string Industry { get; set; }
        public string Issuer { get; set; }
        public string AssetTicket { get; set; }
        public string AssetIsin { get; set; }
        public string AssetName { get; set; }
        public string ActiveType { get; set; }
        public string CurrencyType { get; set; }
    }
}