using Finra.Application.Interfaces.Repositories;
using Finra.Application.Responses;
using Finra.Core.Models;
using Finra.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finra.Infrastructure.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private ApplicationContext _context;

        public AssetRepository(ApplicationContext context)
        {
            _context = context;            
        }

        public async Task<Asset> GetById(int id)
        {
            var query = from a in _context.Assets
                        where a.Id.Equals(id)
                        select new Asset{
                            Id = a.Id,
                            Name = a.Name,
                            Isin = a.Isin,
                            Ticket = a.Ticket,
                            LotSize = a.LotSize,
                            BeginDate = a.BeginDate,
                            EndDate = a.EndDate,
                            ActiveType = a.ActiveType,
                            Exchange = a.Exchange,
                            IssuingCompany = a.IssuingCompany,
                        };

            return await query.SingleOrDefaultAsync();
        }

        public async Task<Asset> GetByIsinCode(string isin)
        {
               var query = from a in _context.Assets
                        where a.Isin.Equals(isin)
                        select new Asset{
                            Id = a.Id,
                            Name = a.Name,
                            Isin = a.Isin,
                            Ticket = a.Ticket,
                            LotSize = a.LotSize,
                            BeginDate = a.BeginDate,
                            EndDate = a.EndDate,
                            ActiveType = a.ActiveType,
                            Exchange = a.Exchange,
                            IssuingCompany = a.IssuingCompany,
                        };

            return await query.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<AssetResponse>> Search(string code, int? activeType)
        {
            if (code.Length < 3)
                throw new Exception("search string length must be greater 3");

            // var query = from a in _context.Assets
            //             where (a.Isin.Contains(code) || a.Ticket.Contains(code)) &&
            //             (a.ActiveTypeId.Equals(activeType) || activeType == null)
            //             group a by a.ActiveTypeId into g
            //             select new AssetByTypeResponse
            //             {
            //                 ActiveType = g.Key,
            //                 Assets = from b in g
            //                          select new AssetResponse {
            //                             Name = b.Name,
            //                             Isin = b.Isin,
            //                             LotSize = b.LotSize
            //                          }
            //             };

            // var asset = query.ToList();

            var query = from a in _context.Assets
                        where (a.Isin.Contains(code) || a.Ticket.Contains(code)) &&
                              (a.ActiveTypeId.Equals(activeType) || activeType == null)
                        select new AssetResponse
                        {
                            Name = a.Name,
                            Isin = a.Isin,
                            LotSize = a.LotSize
                        };

            var asset = await query.ToListAsync();

            return asset;
        }
    }
}