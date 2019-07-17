namespace FizzBuzzAPI.Entities
{
    interface ISerieParameters
    {
        ConfigurationLoader ConfigurationLoader { get; set; }
        int MultipleA { get; set; }
        int MultipleB { get; set; }
        int StartValue { get; set; }
        int EndValue { get; set; }


    }
}
