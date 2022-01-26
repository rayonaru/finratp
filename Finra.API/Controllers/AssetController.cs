using System.Collections.Generic;
using System.Threading.Tasks;
using Finra.Application.Responses;
using Finra.Core.Models;
using Finra.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Finra.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : Controller
    {
        private IAssetRepository _repository;

        public AssetsController(IAssetRepository repository)
        {
            _repository = repository;    
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<Asset> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<Asset> GetByIsinCode([FromQuery(Name = "isin")] string isin)
        {
            return await _repository.GetByIsinCode(isin);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IEnumerable<AssetResponse>> Search([FromQuery(Name = "code")] string code, [FromQuery(Name = "activeType")] int? activeType)
        {
            return await _repository.Search(code, activeType);
        }
    }
}