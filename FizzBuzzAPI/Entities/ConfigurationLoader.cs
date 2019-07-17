using FizzBuzzAPI.Tools;
using Microsoft.Extensions.Configuration;
using System;

namespace FizzBuzzAPI.Entities
{
    public class ConfigurationLoader : IConfigurationLoader
    {
        public ConfigurationLoader(int randomNumber)
        {
            try
            {
                Logger.Log(Logger.LogType.INFO, "FizzBuzzController()", "Cargando configuración.");
                loader(randomNumber);
            } catch (Exception ex)
            {
                throw ex;
            }
        }
        public int MultipleAConfigValue { get; set; }
        public int MultipleBConfigValue { get; set; }
        public int StartValueConfigValue { get; set; }
        public int EndValueConfigValue { get; set; }

        // Cargador de datos desde configuración appsettings.json.
        public void loader(int randomNumber)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.StartValueConfigValue = randomNumber;
            this.EndValueConfigValue = Int32.Parse(configuration["FizzBuzz:EndValue"]);
            this.MultipleAConfigValue = Int32.Parse(configuration["FizzBuzz:MultipleA"]);
            this.MultipleBConfigValue = Int32.Parse(configuration["FizzBuzz:MultipleB"]);

            if ((StartValueConfigValue < 0) || (StartValueConfigValue >= EndValueConfigValue))
                throw new Exception("Valor de inicio de la serie fuera de rango.");
            if ((EndValueConfigValue > 100) || (EndValueConfigValue < 0))
                throw new Exception("Valor final de la serie fuera de rango.");
            if (MultipleAConfigValue < 0)
                throw new Exception("Multiple A 0 o menor.");
            if (MultipleBConfigValue < 0)
                throw new Exception("Multiple B 0 o menor.");
        }
    }
}
