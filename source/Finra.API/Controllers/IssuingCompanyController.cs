using System.Collections.Generic;
using System.Threading.Tasks;
using Finra.Application.Interfaces.Repositories;
using Finra.Application.Responses;
using Finra.Core.Models;
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
        public async Task<IEnumerable<IssuingCompany>> GetAll()
        {
            return await _repository.GetAll();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IEnumerable<AssetWithIssuerResponse>> GetAssetsByIssuingId(int id)
        {
            return await _repository.GetAssetsByIssuedId(id);
        }
    }
}