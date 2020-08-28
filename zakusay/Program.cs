using System;
using zakusay.Services;

namespace zakusay
{
    class Program
    {
        static void Main(string[] args)
        {
            // argsを解析するクラスに渡す
            // 解析した結果、実行コンテキストを表したクラスを返す
            // 実行コンテキストをファクトリに渡して処理系統に応じたサービス（コントローラ？命名検討）クラスをインターフェース経由で返す
            // インターフェースを実行する
            // - パターン１：通常パターン（テンプレート取得→埋め込み→出力）
            // - パターン２：ヘルプパターン(--help で起動して文字列を出力する)
            var words = string.Empty;
            var isCommander = false;
            if (args.Length == 0)
            {
                words = "zakusay [-s] words";
            }
            else if (args.Length == 1)
            {
                words = args[0];
            }
            else if (args[0] == "-s")
            {
                words = args[1];
                isCommander = true;
            }

            Console.ForegroundColor = GetConsoleColor();
            var service = new MobileSuiteService(words, isCommander);
            service.Do();
            Console.ResetColor();
        }

        static private ConsoleColor GetConsoleColor()
        {
            var seed = DateTimeOffset.Now.ToUnixTimeSeconds() % Enum.GetNames(typeof(ConsoleColor)).Length;
            return (ConsoleColor)Enum.ToObject(typeof(ConsoleColor), seed);
        } 
    }
}
