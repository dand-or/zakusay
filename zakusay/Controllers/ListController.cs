using System;
using zakusay.Domains;
using zakusay.Repositories;

namespace zakusay.Controllers
{
    public class ListController : IController
    {
        private readonly IMobileSuitArtRepository _repository;

        public ListController(IMobileSuitArtRepository repository)
        {
            this._repository = repository;
        }

        public void View()
        {
            var mobileSuits = _repository.GetMobileSuitList();
            Console.WriteLine(string.Join(' ', mobileSuits));
        }
    }
}
