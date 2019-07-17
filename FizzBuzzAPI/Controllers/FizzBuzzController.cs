using FizzBuzzAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        // Obtiene una lista con una serie FizzBuzz y la escribe en un fichero de manera asíncrona.
        [HttpGet("{randomNumber}", Name = "BuildFizzBuzzSerie")]
        public List<string> BuildFizzBuzzSerie(int randomNumber)
        {
            // Obtiene la lista de la calculadora de FizzBuzz.
            FizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator(randomNumber);
            List<string> filledSerie = fizzBuzzCalculator.MakeFizzBuzzSerie();

            // Guarda la serie generada en un .txt.
            Writer Writer = new Writer();
            new Thread(Writer.SeriesWriter(filledSerie).Start);

            return filledSerie;
        }
    }
}
