using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        // Llamada a FizzBuzz.
        [HttpGet("{randomNumber}", Name = "BuildFizzBuzzList")]
        public List<string> BuildFizzBuzzList(int randomNumber)
        {

            return new List<String>( );
        }
    }
}
