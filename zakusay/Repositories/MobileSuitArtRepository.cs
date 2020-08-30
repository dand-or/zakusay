using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace zakusay.Repositories
{
    public class MobileSuitArtRepository : IMobileSuitArtRepository
    {
        const string ASSETS_PATH = "Assets/";
        const string TEMPLATE_NAME_DEFAULT = "default";
        const string TEMPLATE_NAME_COMMANDER = "commander";

        public MobileSuitArtRepository()
        {
        }

        public string GetMobileSuitTemplate(string dirName = "zaku2", bool isCommander = false)
        {
            var templateFileName = isCommander ? TEMPLATE_NAME_COMMANDER : TEMPLATE_NAME_DEFAULT;
            var templatePath = Path.Combine(ASSETS_PATH, dirName, templateFileName);
            using (var sr = new StreamReader(templatePath, Encoding.GetEncoding("utf-8")))
            {
                return sr.ReadToEnd();
            }
        }

        public List<string> GetMobileSuitList(){
            return Directory.GetDirectories(ASSETS_PATH).ToList();
        }
    }
}
