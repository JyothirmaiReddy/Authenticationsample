using LoginAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [Authorize(Roles = UserRoles.Admin)]
        [HttpGet]
        [Route("weatheradmin")]
        public string admin()
        {
            return "This is admin from weather";
        }
       
    }
}
