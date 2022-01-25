using System.Collections.Generic;
using Finra.Application.Responses;
using Finra.Core.Models;

namespace Finra.Core.Repositories
{
    public interface IAssetRepository
    {
        Asset GetById(int id);
        Asset GetByIsinCode(string isin);
        IEnumerable<AssetResponse> Search(string code, int? activeType);
    }
}