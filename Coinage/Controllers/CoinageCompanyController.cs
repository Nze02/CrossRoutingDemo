using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Coinage.Controllers
{
    [Route("api/coinage/[controller]")]
    public class CoinageCompanyController : Controller
    {

        private readonly IRepositoryManager _repository;
        //private IMapper _mapper;

        public CoinageCompanyController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        //Get all EcoCompanies
        [HttpGet]
        public async Task<IActionResult> GetAllEcoCompanies()
        {
            var ecoCompanies = await _repository.CoinageCompanyRepository.GetAllEcoCompaniesAsync(trackChanges: false);
            //var ecoCompaniesForOutputDto = _mapper.Map<IEnumerable<EcoCompanyForOutputDto>>(ecoCompanies);

            return Ok(ecoCompanies);
        }
    }
}
