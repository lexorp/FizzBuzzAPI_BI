using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Entities
{
    public class Writer : IWriter
    {
        public Writer()
        {
            try
            {
                // Carga datos de la salida desde el appsettings.json.
                LoadPathData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
                
        }
        public string Path { get; set; }

        // Guarda en un txt la serie rellena y lo guarda por fecha y hora.
        public Task SeriesWriter(List<string> FilledSerie)
        {
            if (FilledSerie == null || FilledSerie.Count == 0)
                throw new Exception("Contenido de salida vacío.");
            return Task.Run(() =>
            {
                string fileName = DateTime.Now.ToString("dd-MM-yyyy-HH-mm") + ".txt";
                using (FileStream stream = new FileStream(System.IO.Path.Combine(Path, fileName), FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                    {
                        for (int i = 0; i < FilledSerie.Count; i++)
                        {
                            writer.Write(FilledSerie[i]);
                            if (i + 1 < FilledSerie.Count)
                                writer.Write(",");
                        }
                        writer.Write("\n");
                    }
                }
            });
        }

        private void LoadPathData()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.Path = configuration["Output:Path"];
            if (!Directory.Exists(this.Path))
            {
                throw new Exception("Directorio de salida erroneo.");
            }
        }
    }
}
