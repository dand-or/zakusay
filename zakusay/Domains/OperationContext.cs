using System;
using System.Collections.Generic;
using System.Linq;

namespace zakusay.Domains
{
    public class OperationContext : IOperationContext
    {
        private const string ARG_LIST = "-l";
        private const string ARG_HELP = "--help";
        private const string ARG_COMMANDER = "-s";
        private const string ARG_FOLDER = "-f";
        private const string DEFAULT_FOLDER = "zaku2";

        public enum OperationMode
        {
            NORMAL,
            SHOW_LIST,
            HELP
        }

        private List<string> _args;
        private string _word;
        private OperationMode _operationMode;
        private bool _isCommander;
        private string _mobileSuitDirName;

        public OperationContext(string[] args)
        {
            this._args = args.ToList();
            this.Init();
        }

        public string GetWord()
        {
            return this._word;
        }

        public OperationMode GetOperationMode()
        {
            return this._operationMode;
        }

        public bool GetIsCommander()
        {
            return this._isCommander;
        }

        public string GetMobileSuitDirName()
        {
            return this._mobileSuitDirName;
        }

        private void Init()
        {
            if (this._args.Any(x => x.Equals(ARG_LIST)))
            {
                this._operationMode = OperationMode.SHOW_LIST;
                return;
            }

            if (this._args.Any(x => x.Equals(ARG_HELP))
                || this._args.Count() == 0)
            {
                this._operationMode = OperationMode.HELP;
                return;
            }

            this._operationMode = OperationMode.NORMAL;

            this._isCommander = this._args.Any(x => x.Equals(ARG_COMMANDER));

            if (this._args.Any(x => x.Equals(ARG_FOLDER)))
            {
                var index = this._args.IndexOf(ARG_FOLDER);
                try
                {
                    this._mobileSuitDirName = this._args[index + 1];
                    this._args.RemoveAt(index + 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    this._operationMode = OperationMode.HELP;
                    return;
                }
            }
            else
            {
                this._mobileSuitDirName = DEFAULT_FOLDER;
            }

            this._word = this._args.Where(x => x != ARG_LIST)
                                   .Where(x => x != ARG_HELP)
                                   .Where(x => x != ARG_COMMANDER)
                                   .Where(x => x != ARG_FOLDER)
                                   .FirstOrDefault();

        }
    }
}
