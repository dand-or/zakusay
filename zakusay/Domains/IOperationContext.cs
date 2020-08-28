namespace zakusay.Domains
{
    public interface IOperationContext
    {
        bool GetIsCommander();
        string GetMobileSuitDirName();
        OperationContext.OperationMode GetOperationMode();
        string GetWord();
    }
}