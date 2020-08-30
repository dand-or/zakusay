using System.Collections.Generic;
namespace zakusay.Repositories
{
    public interface IMobileSuitArtRepository
    {
        string GetMobileSuitTemplate(string dirName = "zaku2", bool isCommander = false);
        List<string> GetMobileSuitList();
    }
}