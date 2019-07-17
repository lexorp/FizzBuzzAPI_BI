using FizzBuzzAPI.Models;
using FizzBuzzAPI.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        // Obtiene una lista FizzBuzz y la escribe en un ficheor 
        [HttpGet("{randomNumber}", Name = "GetFizzBuzzSerie")]
        public ActionResult<List<string>> GetFizzBuzzSerie(int RandomNumber)
        {
            try
            {
                Logger.Log(Logger.LogType.DEBUG, "FizzBuzzController()", "Texto de prueba entrando en el método.");
                return Ok(new FizzBuzzModel().ProcessFizzBuzz(RandomNumber));
            } catch (Exception ex)
            {
                Logger.Log(Logger.LogType.ERROR, "FizzBuzzController()", ex.Message);
                return this.BadRequest(ex.Message);
            }
            
        }
    }
}
