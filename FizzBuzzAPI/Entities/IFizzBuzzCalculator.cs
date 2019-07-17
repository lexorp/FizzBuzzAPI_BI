using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Entities
{
    interface IFizzBuzzCalculator
    {
        SerieParameters SerieParameters { get; set; }
        List<string> MakeFizzBuzzSerie();
    }
}
