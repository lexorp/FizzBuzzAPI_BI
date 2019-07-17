using System;

namespace FizzBuzzAPI.Entities
{
    public class SerieParameters : ISerieParameters
    {
        public SerieParameters(int randomNumber)
        {
            try
            {
                this.ConfigurationLoader = new ConfigurationLoader(randomNumber);
            } catch (Exception ex)
            {
                throw ex;
            }
            loadValues(ConfigurationLoader);
        }

        // Llamadas a la clase de carga de condfiguración
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
