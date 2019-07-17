using System.Collections.Generic;
using System.Threading.Tasks;

namespace FizzBuzzAPI.Entities
{
    interface IWriter
    {
        string Path { get; set; }
        Task SeriesWriter(List<string> FilledSerie);
    }
}
