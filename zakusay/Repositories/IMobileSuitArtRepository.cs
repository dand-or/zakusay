namespace zakusay.Repositories
{
    public interface IMobileSuitArtRepository
    {
        string GetMobileSuitTemplate(string dirName = "zaku2", bool isCommander = false);
    }
}