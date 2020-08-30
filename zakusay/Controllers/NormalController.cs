using System;
using zakusay.Domains;
using zakusay.Repositories;

namespace zakusay.Controllers
{
    public class NormalController : IController
    {
        private const string REPLACER = "replacer";
        private readonly IOperationContext _context;
        private readonly IMobileSuitArtRepository _repository;

        public NormalController(IOperationContext context, IMobileSuitArtRepository repository)
        {
            this._context = context;
            this._repository = repository;
        }

        public void View()
        {
            var template = this._repository.GetMobileSuitTemplate(this._context.GetMobileSuitDirName(), this._context.GetIsCommander());
            Console.WriteLine(template.Replace(REPLACER, this._context.GetWord()));
        }
    }
}
