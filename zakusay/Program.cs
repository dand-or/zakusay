using System;
using System.Threading.Tasks;

namespace zakusay
{
    class Program
    {
        const string zaku = @"
\ replacer /
        ____ 
      /_|_|__\
      |__O__||
     ((([=]))))      
";

        static void Main(string[] args)
        {
            Console.ForegroundColor = GetConsoleColor();
            var words = args.Length > 0 ? args[0] : DateTime.Now.ToString();
            var output = zaku.Replace("replacer", words);
            Console.WriteLine(output);
            Console.ResetColor();
        }

        static private ConsoleColor GetConsoleColor()
        {
            var seed = DateTimeOffset.Now.ToUnixTimeSeconds() % Enum.GetNames(typeof(ConsoleColor)).Length;
            return (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), seed);
        } 
    }
}
