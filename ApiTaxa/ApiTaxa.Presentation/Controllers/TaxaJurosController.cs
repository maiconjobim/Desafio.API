using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTaxa.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTaxa.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
    
        private readonly ILogger<TaxaJurosController> _logger;
        private readonly ITaxaRespository _respository;

        public TaxaJurosController(ILogger<TaxaJurosController> logger,ITaxaRespository respository)
        {
            _logger = logger;
            _respository = respository;
        }

        [HttpGet]
        public double Get() => _respository.getTaxa();
        
    }
}
