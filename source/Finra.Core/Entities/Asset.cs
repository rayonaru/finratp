using System;

namespace Finra.Core.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Ticket { get; set; }
        public string Isin { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int LotSize { get; set; }

        public int CurrencyTypeid { get; set; }
        public CurrencyType CurrencyType { get; set; }

        public int ExchangeId { get; set; }
        public Exchange Exchange { get; set; }

        public int IssuingCompanyId { get; set; }
        public IssuingCompany IssuingCompany { get; set; }

        public int ActiveTypeId { get; set; }
        public ActiveType ActiveType { get; set; }
    }
}