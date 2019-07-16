using System;
using System.Collections.Generic;

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
            for (int i = SerieParameters.StartValue; i < SerieParameters.EndValue; i++)
            {
                if (i % SerieParameters.MultipleA == 0)
                {
                    if (i %  SerieParameters.MultipleB == 0)
                    {
                        FizzBuzzSerie.Add("FizzBuzz");
                    }
                    else
                    {
                        FizzBuzzSerie.Add("Fizz");
                    }
                }
                else if (i % SerieParameters.MultipleB == 0)
                {
                    FizzBuzzSerie.Add("Buzz");
                }
                else
                {
                    FizzBuzzSerie.Add(i.ToString());
                }
            }
            return FizzBuzzSerie;
        }
    }
}
