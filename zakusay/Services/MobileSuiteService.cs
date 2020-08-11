using System;
using zakusay.Domains;

namespace zakusay.Services
{
    public class MobileSuiteService
    {
        private string _words;
        private string _template;

        public MobileSuiteService(string words, bool isCommander = false)
        {
            this._words = words;
            this._template = isCommander ? MobileSuiteArtTemplates.MS06S : MobileSuiteArtTemplates.MS06;
        }

        public void Do()
        {
            var output = this._template.Replace("replacer", this._words);
            Console.WriteLine(output);
        }
    }
}
