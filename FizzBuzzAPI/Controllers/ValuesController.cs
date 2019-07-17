using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {


            return new ActionResult<string>("");
        }

        // GET api/values/5
        [HttpGet("{iterations}")]
        public async Task<ActionResult<string>> Get(int iterations)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            #region Test escritura .txt asincrónica.
            string filePath = Path.Combine(configuration["Output:Path"], configuration["Output:FileName"]);
            await Task.Run(() =>
            {
                
            });

            return "Proceso largo terminado";
            #endregion
        }
    }
}
