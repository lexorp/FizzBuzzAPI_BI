using FizzBuzzAPI.Entities;
using FizzBuzzAPI.Tools;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzzModel : IFizzBuzzModel
    {
        public List<string> ProcessFizzBuzz(int RandomNumber)
        {
            FizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator(RandomNumber);
            List<string> filledSerie = null;
            try
            {
                // Obtiene la serie rellena desde la calculadora de FizzBuzz.
                Logger.Log(Logger.LogType.DEBUG, "FizzBuzzController()", "Número aleatorio " + RandomNumber.ToString());
                filledSerie = fizzBuzzCalculator.MakeFizzBuzzSerie();
            }catch (Exception ex)
            {
                throw ex;
            }

            // Guarda la serie generada en un .txt.
            try
            {
                Writer Writer = new Writer();
                new Thread(Writer.SeriesWriter(filledSerie).Start);
            } catch (Exception ex)
            {
                throw ex;
            }
            return filledSerie;
        }
    }
}
