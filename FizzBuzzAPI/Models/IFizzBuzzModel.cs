using System.Collections.Generic;

namespace FizzBuzzAPI.Models
{
    interface IFizzBuzzModel
    {
        List<string> ProcessFizzBuzz(int RandomNumber);
    }
}
