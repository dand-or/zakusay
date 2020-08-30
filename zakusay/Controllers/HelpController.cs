using System;
using System.Diagnostics;
using System.Reflection;

namespace zakusay.Controllers
{
    public class HelpController : IController
    {
        private readonly FileVersionInfo _version;

        public HelpController()
        {
            this._version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        }

        public void View()
        {
            Console.WriteLine(GetHelp());
        }

        private string GetHelp()
        {
            var help = @"
zakusay
{0}

Usage: zakusay [-OPTIONS [-MORE_OPTIONS]] [PROGRAM_ARG1 ...]

The following options are accepted:
	With arguments: -s -l -f --help

     -s        use commander template

     -l        show usable template names

     -f [file] use file template (default is zaku2)

     --help    show help
";
            return string.Format(help, this._version);
        }
    }
}
