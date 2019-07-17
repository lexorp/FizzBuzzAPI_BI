using FizzBuzzAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace FizzBuzzAPI.Models
{
    public class FizzBuzzModel : IFizzBuzzModel
    {
        public List<string> ProcessFizzBuzz(int RandomNumber)
        {
            // Obtiene la lista de la calculadora de FizzBuzz.
            FizzBuzzCalculator fizzBuzzCalculator = new FizzBuzzCalculator(RandomNumber);
            List<string> filledSerie = null;
            try
            {
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
