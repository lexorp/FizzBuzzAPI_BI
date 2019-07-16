using System.Collections.Generic;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Models
{
    interface IWriter
    {
        string Path { get; set; }
        string FileName { get; set; }
        Task SeriesWriter(List<string> FilledSerie);
    }
}
