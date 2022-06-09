using LoginAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class userjwtController : ControllerBase
    {
        [Authorize(Roles = UserRoles.User)]
        [HttpGet]
        [Route("weatheruser")]
        public string user()
        {
            return "This is user from weather";
        }
    }
}
