using System;
namespace zakusay.Domains
{
    public class OperationContext
    {
        enum OperationMode
        {
            NORMAL,
            SHOW_LIST, // -l option
            HELP // --help option
        }

        private string[] _args;
        private string _word;
        private OperationMode _operationMode;
        private bool _isCommander;
        private bool _mobileSuitDirName;

        public OperationContext(string[] args)
        {
            this._args = args;
        }
    }
}
