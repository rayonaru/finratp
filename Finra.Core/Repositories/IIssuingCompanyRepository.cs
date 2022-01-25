using System.Collections.Generic;
using Finra.Application.Responses;
using Finra.Core.Models;

namespace Finra.Core.Repositories
{
    public interface IIssuingCompanyRepository
    {
        IEnumerable<IssuingCompany> GetAll();
        IEnumerable<AssetWithIssuerResponse> GetAssetsByIssuedId(int id);
    }
}