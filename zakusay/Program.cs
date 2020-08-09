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
            var words = args.Length > 0 ? args[0] : DateTime.Now.ToString();
            var output = zaku.Replace("replacer", words);
            Console.WriteLine(output);
        }
    }
}
