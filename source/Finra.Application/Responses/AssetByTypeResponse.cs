using System.Collections.Generic;

namespace Finra.Application.Responses
{
    public class AssetByTypeResponse
    {
        public int ActiveType { get; set; }
        public IEnumerable<AssetResponse> Assets { get; set; }
    }

    public class AssetResponse 
    {
        public string Name { get; set; }
        public string Isin { get; set; }
        public int LotSize { get; set; }
    }
}