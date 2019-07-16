using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    public class Writer : IWriter
    {
        public Writer()
        {
            LoadPathData();
        }
        public string Path { get; set; }
        public string FileName { get; set; }

        public async Task SeriesWriter(List<string> FilledSerie)
        {
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(Path, FileName)))
            {
                await Task.Run(() => 
                {
                    outputFile.WriteAsync(FilledSerie.ToString());
                });
            }
        }

        private void LoadPathData()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this.Path = configuration["Output : Path"];
            this.FileName = configuration["Output : FileName"];
        }


    }
}
