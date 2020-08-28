using NUnit.Framework;
using zakusay.Repositories;

namespace zakusay.test
{
    public class MobileSuitArtRepositoryTests
    {
        const string ZAKU2_DEFAULT = @"\ replacer /
        _____
      /_|_|__\
      |__O__||
     ((([=]))))";

        const string ZAKU2_COMMANDER = @"\ replacer /
       _\____
      /_|\|__\
      |__@__||
     ((([=]))))";

        const string DOM_DEFAULT = @"\ replacer /
      ____
    _//  \_`.
   || @) _|| \
   /(\__//))))\";

        const string DOM_COMMANDER = @"\ replacer /
      _/__
    _//  \_`.
   || O) _|| \
   /(\__//))))\";


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetMobileSuitTemplateTest_Default_Will_Success()
        {
            var repo = new MobileSuitArtRepository();
            var template = repo.GetMobileSuitTemplate();
            Assert.AreEqual(ZAKU2_DEFAULT, template);
        }

        [Test]
        public void GetMobileSuitTemplateTest_Zaku2Default_Will_Success()
        {
            var repo = new MobileSuitArtRepository();
            var template = repo.GetMobileSuitTemplate("zaku2");
            Assert.AreEqual(ZAKU2_DEFAULT, template);
        }

        [Test]
        public void GetMobileSuitTemplateTest_Zaku2Commander_Will_Success()
        {
            var repo = new MobileSuitArtRepository();
            var template = repo.GetMobileSuitTemplate("zaku2", true);
            Assert.AreEqual(ZAKU2_COMMANDER, template);
        }

        [Test]
        public void GetMobileSuitTemplateTest_DomDefault_Will_Success()
        {
            var repo = new MobileSuitArtRepository();
            var template = repo.GetMobileSuitTemplate("dom");
            Assert.AreEqual(DOM_DEFAULT, template);
        }

        [Test]
        public void GetMobileSuitTemplateTest_DomCommander_Will_Success()
        {
            var repo = new MobileSuitArtRepository();
            var template = repo.GetMobileSuitTemplate("dom", true);
            Assert.AreEqual(DOM_COMMANDER, template);
        }
    }
}