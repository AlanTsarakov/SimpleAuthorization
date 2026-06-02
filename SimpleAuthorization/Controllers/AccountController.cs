using Microsoft.AspNetCore.Mvc;

namespace SimpleAuthorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountContoller : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        
        public AccountContoller(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

    }
}
