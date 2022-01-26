using System.Collections.Generic;
using System.Threading.Tasks;
using Finra.Application.Responses;
using Finra.Core.Models;

namespace Finra.Application.Interfaces.Repositories
{
    public interface IAssetRepository
    {
        Task<Asset> GetById(int id);
        Task<Asset> GetByIsinCode(string isin);
        Task<IEnumerable<AssetResponse>> Search(string code, int? activeType);
    }
}