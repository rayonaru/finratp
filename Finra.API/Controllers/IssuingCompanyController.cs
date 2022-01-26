using System.Threading.Tasks;
using Finra.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Finra.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IssuingCompaniesController : Controller
    {
        private IIssuingCompanyRepository _repository;

        public IssuingCompaniesController(IIssuingCompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var issuers = await _repository.GetAll();

            return Ok(issuers);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetAssetsByIssuingId(int id)
        {
            var assets = await _repository.GetAssetsByIssuedId(id);

            return Ok(assets);
        }
    }
}