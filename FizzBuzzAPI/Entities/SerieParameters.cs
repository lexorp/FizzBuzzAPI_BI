using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Entities
{
    public class SerieParameters : ISerieParameters
    {
        public SerieParameters(int randomNumber)
        {
            this.ConfigurationLoader = new ConfigurationLoader(randomNumber);
            loadValues(ConfigurationLoader);
        }

        private void loadValues(ConfigurationLoader confLoader)
        {
            MultipleA = confLoader.MultipleAConfigValue;
            MultipleB = confLoader.MultipleBConfigValue;
            StartValue = confLoader.StartValueConfigValue;
            EndValue = confLoader.EndValueConfigValue;
        }

        public int MultipleA { get; set; }
        public int MultipleB { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }

        public ConfigurationLoader ConfigurationLoader { get; set; }
    }
}
