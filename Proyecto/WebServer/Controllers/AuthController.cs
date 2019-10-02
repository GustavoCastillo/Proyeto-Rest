using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebServer.Models;
using WebServer.Security;
//using WebServer.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        public IConfiguration Configuration { get; set; }
        // GET: api/<controller>

        public AuthController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult GetToken([FromBody] User credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (credentials.UserName != "admin")
            {
                return Unauthorized();
            }

            var Token = Security.JwtTokenBuilder.GetSecuredToken(Configuration);
           
            return Ok(new { Token = JwtTokenBuilder.WriteToken(Token) });
                }

    }
}
