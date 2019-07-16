using FizzBuzzAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        // Obtiene una lista con una serie FizzBuzz y la escribe en un fichero de manera asíncrona.
        [HttpGet("{randomNumber}", Name = "BuildFizzBuzzSerie")]
        public async Task<List<string>> BuildFizzBuzzSerie(int randomNumber)
        {
            // Obtiene la lista de la calculadora de FizzBuzz.
            FizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator(randomNumber);
            List<string> filledSerie = fizzBuzzCalculator.MakeFizzBuzzSerie();

            // Guarda de manera asíncrona la serie generada en un .txt.
            await new Writer().SeriesWriter(filledSerie);

            return filledSerie;
        }
    }
}
