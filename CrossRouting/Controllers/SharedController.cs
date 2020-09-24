using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using Microsoft.Extensions.Logging;
using Repositories.Contracts;

namespace CrossRouting.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/{*url}")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IRepositoryManager _repository;
        //private IMapper _mapper;

        public SharedController(IRepositoryManager repository, ILogger<SharedController> logger)
        {
            _repository = repository;
            _logger = logger;
        }


        //Get all EcoCompanies
        //[Route("api/{*url}")]
        [HttpGet]
        public async Task<IActionResult> GetAllEcoCompanies()
        {

            var route = ControllerContext.MyDisplayRouteInfo();
            string Message = $"THE CALLING URL IS: {route}";
            _logger.LogError(Message);

            var ecoCompanies = await _repository.CoinageCompanyRepository.GetAllEcoCompaniesAsync(trackChanges: false);

            return Ok(ecoCompanies);
        }

    }
}

