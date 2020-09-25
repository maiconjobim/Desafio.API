using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domian.Commands.Requests;
using Domian.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class  CalculaJurosController : ControllerBase
    {
    
        private readonly ILogger<CalculaJurosController> _logger;

        public  CalculaJurosController(ILogger< CalculaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<CalculaJurosResponse>> Get(
            [FromServices]IMediator mediator,
            [FromQuery] CalculaJurosRequest command
        )
        {
            try
            {
                var response = await mediator.Send(command);
                return Ok(response);    
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
          
        }
    }
}
