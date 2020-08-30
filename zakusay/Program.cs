using System;
using zakusay.Domains;
using zakusay.Controllers;

namespace zakusay
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new OperationContext(args);
            var controller = ControllerFactory.CreateController(context);

            Console.ForegroundColor = GetConsoleColor();
            controller.View();
            Console.ResetColor();
        }

        static private ConsoleColor GetConsoleColor()
        {
            var seed = DateTimeOffset.Now.ToUnixTimeSeconds() % Enum.GetNames(typeof(ConsoleColor)).Length;
            return (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), seed);
        } 
    }
}
