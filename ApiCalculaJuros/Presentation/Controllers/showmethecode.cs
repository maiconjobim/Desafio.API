using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Controllers
{
    public class showmethecodeController : ControllerBase
    {

         private readonly ILogger<showmethecodeController> _logger;

        public showmethecodeController(ILogger<showmethecodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
          return "rota do gitHub";
        }
    }
}