using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public FizzBuzzCalculator(int RandomNumber)
        {
            this.SerieParameters = new SerieParameters(RandomNumber);
        }

        public SerieParameters SerieParameters { get; set; }

        public List<string> MakeFizzBuzzSerie()
        {
            List<String> FizzBuzzSerie = new List<string>();
            for (int i=SerieParameters.StartValue; i < SerieParameters.EndValue; i++)
            {
                if (SerieParameters.MultipleA % i == 0)
                {
                    if (SerieParameters.MultipleB % i == 0)
                    {
                        FizzBuzzSerie.Add("Fizz-Buzz");
                    } else
                    {
                        FizzBuzzSerie.Add("Fizz");
                    }
                } else if (SerieParameters.MultipleB % i == 0)
                {
                    FizzBuzzSerie.Add("Buzz");
                } else
                {
                    FizzBuzzSerie.Add(i.ToString());
                }
            }
            return FizzBuzzSerie;
        }
    }
}
