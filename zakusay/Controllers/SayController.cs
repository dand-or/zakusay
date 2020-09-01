using System;
using zakusay.Domains;
using zakusay.Repositories;

namespace zakusay.Controllers
{
    public class SayController : IController
    {
        private const string REPLACER = "replacer";
        private readonly IOperationContext _context;
        private readonly IMobileSuitArtRepository _repository;

        public SayController(IOperationContext context, IMobileSuitArtRepository repository)
        {
            this._context = context;
            this._repository = repository;
        }

        public void View()
        {
            Console.ForegroundColor = GetConsoleColor();
            var template = this._repository.GetMobileSuitTemplate(this._context.GetMobileSuitDirName(), this._context.GetIsCommander());
            Console.WriteLine(template.Replace(REPLACER, this._context.GetWord()));
            Console.ResetColor();
        }

        private ConsoleColor GetConsoleColor()
        {
            var seed = DateTimeOffset.Now.ToUnixTimeSeconds() % Enum.GetNames(typeof(ConsoleColor)).Length;
            return (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), seed);
        }
    }
}
