using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        // Obtiene una lista con una serie FizzBuzz y la escribe en un fichero de manera asíncrona.
        [HttpGet("{randomNumber}", Name = "BuildFizzBuzzList")]
        public async Task<List<string>> BuildFizzBuzzList(int randomNumber)
        {
            // Se obtiene la lista FizzBuzz pasando un número aleatorio.
            FizzBuzzCalculator fizzBuzzCalculator = 
            // Se almacena la lista en el fichero.

            return new List<string>();
        }
    }
}
