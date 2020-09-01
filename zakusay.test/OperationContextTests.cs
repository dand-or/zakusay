using NUnit.Framework;
using zakusay.Domains;

namespace zakusay.test
{
    public class OperationContextTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetWordTest()
        {
            var expectedWord = "test";
            var args = new string[1] { expectedWord };
            var context = new OperationContext(args);
            Assert.AreEqual(expectedWord, context.GetWord());
        }

        [Test]
        public void GetOperationModeTest_SAY()
        {
            var args = new string[1] { "." };
            var context = new OperationContext(args);
            Assert.AreEqual(OperationContext.OperationMode.SAY, context.GetOperationMode());
        }

        [Test]
        public void GetOperationModeTest_LIST()
        {
            var args = new string[1] { "-l" };
            var context = new OperationContext(args);
            Assert.AreEqual(OperationContext.OperationMode.SHOW_LIST, context.GetOperationMode());
        }


        [Test]
        public void GetOperationModeTest_HELP()
        {
            var args = new string[1] { "--help" };
            var context = new OperationContext(args);
            Assert.AreEqual(OperationContext.OperationMode.HELP, context.GetOperationMode());
        }

        [Test]
        public void GetIsCommanderTest_True()
        {
            var args = new string[2] { "-s", "hoge" };
            var context = new OperationContext(args);
            Assert.IsTrue(context.GetIsCommander());
        }

        [Test]
        public void GetIsCommanderTest_False()
        {
            var args = new string[3] { "-f", "zaku2", "hoge" };
            var context = new OperationContext(args);
            Assert.IsFalse(context.GetIsCommander());
        }

        [Test]
        public void GetMobileSuitDirNameTest()
        {
            var args = new string[3] { "-f", "dom", "hoge" };
            var context = new OperationContext(args);
            Assert.AreEqual("dom", context.GetMobileSuitDirName());
        }

        [Test]
        public void GetWordTest_MultipleArgs()
        {
            var args = new string[3] { "-f", "dom", "hoge" };
            var context = new OperationContext(args);
            Assert.AreEqual("hoge", context.GetWord());
        }

        [Test]
        public void FolderArgInvalidTest()
        {
            var args = new string[1] { "-f" };
            var context = new OperationContext(args);
            Assert.AreEqual(OperationContext.OperationMode.HELP, context.GetOperationMode());
        }
    }
}