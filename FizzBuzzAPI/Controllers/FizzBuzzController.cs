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
            FizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator(randomNumber);
            List<string> filledSerie = fizzBuzzCalculator.MakeFizzBuzzSerie();
            // Faltaría escribir en fichero asyncronamente todo.

            return filledSerie;
        }
    }
}
