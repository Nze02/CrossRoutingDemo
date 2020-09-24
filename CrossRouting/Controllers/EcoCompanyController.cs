using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;

namespace CrossRouting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EcoCompanyController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        //private IMapper _mapper;

        public EcoCompanyController(IRepositoryManager repository)
        {
            _repository = repository;
        }


        //Get all EcoCompanies
        //[HttpGet]
        //public async Task<IActionResult> GetAllEcoCompanies()
        //{
        //    var ecoCompanies = await _repository.CompanyRepository.GetAllEcoCompaniesAsync(trackChanges: false);
        //    //var ecoCompaniesForOutputDto = _mapper.Map<IEnumerable<EcoCompanyForOutputDto>>(ecoCompanies);

        //    return Ok(ecoCompanies);
        //}
    }
}
