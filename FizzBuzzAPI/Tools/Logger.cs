using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Tools
{
    public static class Logger
    {                                   //LogType, DateTime, Método, texto
        private const string format = "[\"{0}\" \"{1}\" \"{2}\"] \"{3}\"\n";

        public enum LogType
        {
            INFO,
            DEBUG,
            ERROR
        }

        // Imprime una línea en el log de errores según los valores entrantes.
        public static void Log(LogType logType, string classe, string text)
        {
            try
            {
                string Path = GetLogPathInfo();
                using (FileStream stream = new FileStream(System.IO.Path.Combine(Path, DateTime.Now.ToString("dd-MM-yyyy") + ".txt"), FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        writer.Write(format, logType.ToString(), DateTime.Now.ToString("dd-MM-yyyy-hh:mm:ss"), classe, text);
                    }
                }
            } catch (FileNotFoundException ex)
            {
                throw ex;
            }
            
        }
        
        private static string GetLogPathInfo()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();
            string path = configuration["Logging:Path"];
            if ((path == null) || (path == ""))
                throw new Exception("Ruta de archivo de logs erronea.");
            return path;
        }
    }
}
