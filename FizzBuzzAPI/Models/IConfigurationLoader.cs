namespace FizzBuzzAPI.Models
{
    interface IConfigurationLoader
    {
        int MultipleAConfigValue { get; set; }
        int MultipleBConfigValue { get; set; }
        int StartValueConfigValue { get; set; }
        int EndValueConfigValue { get; set; }
        void loader(int startValue);
    }
}
