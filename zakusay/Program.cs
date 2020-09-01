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
            controller.View();
        }
    }
}
