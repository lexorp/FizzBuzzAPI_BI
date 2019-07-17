using FizzBuzzAPI.Models;
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
                return Ok(new FizzBuzzModel().ProcessFizzBuzz(RandomNumber));
            } catch (Exception ex)
            {
                // LOGGIN
                return this.BadRequest(ex.Message);
            }
            
        }
    }
}
