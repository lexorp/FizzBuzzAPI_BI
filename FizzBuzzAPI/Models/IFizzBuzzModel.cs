using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    interface IFizzBuzzModel
    {
        List<string> ProcessFizzBuzz(int RandomNumber);
    }
}
