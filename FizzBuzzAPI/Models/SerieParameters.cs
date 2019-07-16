using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class SerieParameters : ISerieParameters
    {
        public int MultipleA { get; set; }
        public int MultipleB { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public ConfigurationLoader configurationLoader => throw new NotImplementedException();
    }
}
