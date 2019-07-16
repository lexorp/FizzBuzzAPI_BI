using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    interface IFizzBuzzCalculator
    {
        SerieParameters serie { get; set; }
        List<string> MakeFizzBuzzSerie(int MultipleA, int MultipleB, int StartValue, int EndValue);
    }
}
