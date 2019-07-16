using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public FizzBuzzCalculator(int StartValue)
        {
            loadDataFromConfig();
            this.StartValue = StartValue;
        }

        public int MultipleA { get; set; }
        public int MultipleB { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public List<string> MakeFizzBuzzSerie()
        {
            List<String> FizzBuzzSerie = new List<string>();
            for (int i=StartValue; i < EndValue; i++)
            {
                if (MultipleA % i == 0)
                {
                    if (MultipleB % i == 0)
                    {
                        FizzBuzzSerie.Add("Fizz-Buzz");
                    } else
                    {
                        FizzBuzzSerie.Add("Fizz");
                    }
                } else if (MultipleB % i == 0)
                {
                    FizzBuzzSerie.Add("Buzz");
                } else
                {
                    FizzBuzzSerie.Add(i.ToString());
                }
            }
            return FizzBuzzSerie;
        }

        // Recoge los valores múltiples y el máximo desde la configuración.
        private void loadDataFromConfig()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.EndValue = Int32.Parse(configuration["FizzBuzz:MaxValue"]);
            this.MultipleA = Int32.Parse(configuration["FizzBuzz:MultipleA"]);
            this.MultipleB = Int32.Parse(configuration["FizzBuzz:MultipleB"]);
        }
    }
}
