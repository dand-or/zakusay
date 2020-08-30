using System;
using zakusay.Domains;
using zakusay.Repositories;

namespace zakusay.Controllers
{
    public static class ControllerFactory
    {
        public static IController CreateController(IOperationContext context)
        {
            if (context.GetOperationMode() == OperationContext.OperationMode.NORMAL)
            {
                return new NormalController(context, new MobileSuitArtRepository());
            }
            else if (context.GetOperationMode() == OperationContext.OperationMode.SHOW_LIST)
            {
                return new ListController(new MobileSuitArtRepository());
            }
            return new HelpController();
        }
    }
}
