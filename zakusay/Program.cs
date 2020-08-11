using System;
using zakusay.Services;

namespace zakusay
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = string.Empty;
            var isCommander = false;
            if (args.Length == 0)
            {
                words = "zakusay [-s] words";
            }
            else if (args.Length == 1)
            {
                words = args[0];
            }
            else if (args[0] == "-s")
            {
                words = args[1];
                isCommander = true;
            }

            Console.ForegroundColor = GetConsoleColor();
            var service = new MobileSuiteService(words, isCommander);
            service.Do();
            Console.ResetColor();
        }

        static private ConsoleColor GetConsoleColor()
        {
            var seed = DateTimeOffset.Now.ToUnixTimeSeconds() % Enum.GetNames(typeof(ConsoleColor)).Length;
            return (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), seed);
        } 
    }
}
