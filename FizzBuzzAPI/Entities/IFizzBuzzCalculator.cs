using System.Collections.Generic;

namespace FizzBuzzAPI.Entities
{
    interface IFizzBuzzCalculator
    {
        SerieParameters SerieParameters { get; set; }
        List<string> MakeFizzBuzzSerie();
    }
}
