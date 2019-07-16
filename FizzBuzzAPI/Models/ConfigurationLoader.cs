using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class ConfigurationLoader : IConfigurationLoader
    {
        public ConfigurationLoader(int randomNumber)
        {
            loader(randomNumber);
        }
        public int MultipleAConfigValue { get; set; }
        public int MultipleBConfigValue { get; set; }
        public int StartValueConfigValue { get; set; }
        public int EndValueConfigValue { get; set; }

        public void loader(int randomNumber)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.StartValueConfigValue = randomNumber;
            this.EndValueConfigValue = Int32.Parse(configuration["FizzBuzz:EndValue"]);
            this.MultipleAConfigValue = Int32.Parse(configuration["FizzBuzz:MultipleA"]);
            this.MultipleBConfigValue = Int32.Parse(configuration["FizzBuzz:MultipleB"]);
        }
    }
}
