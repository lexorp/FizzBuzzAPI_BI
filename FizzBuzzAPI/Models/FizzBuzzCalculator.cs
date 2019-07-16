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
        }

        public SerieParameters serie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<string> MakeFizzBuzzSerie(int MultipleA, int MultipleB, int StartValue, int EndValue)
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
    }
}
