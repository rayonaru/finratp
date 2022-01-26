using System.Collections.Generic;
using System.Threading.Tasks;
using Finra.Application.Responses;
using Finra.Core.Models;

namespace Finra.Core.Repositories
{
    public interface IIssuingCompanyRepository
    {
        Task<IEnumerable<IssuingCompany>> GetAll();
        Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuedId(int id);
    }
}