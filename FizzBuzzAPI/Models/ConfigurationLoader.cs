using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class ConfigurationLoader : IConfigurationLoader
    {
        public int MultipleA { get; set; }
        public int MultipleB { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public void loader(int startValue)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.StartValue = startValue;
            this.EndValue = Int32.Parse(configuration["FizzBuzz:MaxValue"]);
            this.MultipleA = Int32.Parse(configuration["FizzBuzz:MultipleA"]);
            this.MultipleB = Int32.Parse(configuration["FizzBuzz:MultipleB"]);
        }
    }
}
