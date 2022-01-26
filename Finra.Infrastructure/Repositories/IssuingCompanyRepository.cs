using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finra.Application.Responses;
using Finra.Core.Models;
using Finra.Core.Repositories;
using Finra.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Finra.Infrastructure.Repositories
{
    public class IssuingCompanyRepository : IIssuingCompanyRepository
    {
        private ApplicationContext _context;

        public IssuingCompanyRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<IssuingCompany>> GetAll()
        {
            var query = from ic in _context.IssuingCompanies
                        select new IssuingCompany{
                            Id = ic.Id,
                            Name = ic.Name,
                            Country = ic.Country,
                            Industry = ic.Industry
                        };                  

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuedId(int id)
        {
            var query = from ic in _context.IssuingCompanies
                        join a in _context.Assets on ic.Id equals a.IssuingCompany.Id
                        where ic.Id.Equals(id) && 
                              a.EndDate.HasValue.Equals(false)
                        orderby a.BeginDate
                        select new AssetWithIssuerResponse{
                            ActiveType = a.ActiveType.Name,
                            AssetIsin = a.Isin,
                            AssetName = a.Name,
                            AssetTicket = a.Ticket,
                            Country = ic.Country.Name,
                            CurrencyType = a.CurrencyType.Name,
                            Industry = ic.Industry.Name,
                            Issuer = ic.Name
                        };

            return await query.ToListAsync();
        }
    }
}