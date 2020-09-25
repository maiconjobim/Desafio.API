using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domian.Commands.Requests;
using Domian.Commands.Responses;
using Domian.Respositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("")]
    public class  CalculaJurosController : ControllerBase
    {
    
        private readonly ILogger<CalculaJurosController> _logger;
        private readonly IShowMeTheCodeRepository  _repository;

        public CalculaJurosController(ILogger<CalculaJurosController> logger, IShowMeTheCodeRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        [Route("calculajuros")]
        public async Task<ActionResult<CalculaJurosResponse>> GetCalculaJuros(
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

         [HttpGet]
        [Route("showmethecode")]
        public async Task<ActionResult<string>> GetCode()
        {
            try
            {
                string response = await _repository.GetLink();
                return Ok(response);    
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
          
        }
    }
}
