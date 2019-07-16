using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    interface IFizzBuzzCalculator
    {
        int MultipleA { get; set; }
        int MultipleB { get; set; }
        int StartValue { get; set; }
        int EndValue { get; set; }
        List<string> MakeFizzBuzzSerie();
    }
}
