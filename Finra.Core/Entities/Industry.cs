using System.Collections.Generic;

namespace Finra.Core.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public List<IssuingCompany> IssuingCompanies { get; set; }
    }
}