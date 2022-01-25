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
        public IActionResult GetById(int id)
        {
            var asset = _repository.GetById(id);

            return Ok(asset);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByIsinCode([FromQuery(Name = "isin")] string isin)
        {
            var asset = _repository.GetByIsinCode(isin);

            return Ok(asset);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Search([FromQuery(Name = "code")] string code, [FromQuery(Name = "activeType")] int? activeType)
        {
            var asset = _repository.Search(code, activeType);

            return Ok(asset);
        }
    }
}