using System.Collections.Generic;

namespace Finra.Core.Models
{
    public class CurrencyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<Asset> Assets { get; set; }
    }
}