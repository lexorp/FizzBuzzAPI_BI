using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    interface IConfigurationLoader
    {
        int MultipleA { get; set; }
        int MultipleB { get; set; }
        int StartValue { get; set; }
        int EndValue { get; set; }
        void loader(int startValue);
    }
}
