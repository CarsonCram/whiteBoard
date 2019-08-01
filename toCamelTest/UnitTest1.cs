using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace toCamelCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("heyImCarson", Program.toCamel("HEY IM CARSON"));
        }
        public void TestMethod2()
        {
            Assert.AreEqual("it'sAWonderfulLife", Program.toCamel("it's a wonderful life"));
        }
        public void TestMethod3()
        {
            Assert.AreEqual("cramLikesTacos", Program.toCamel("cram likes tacos"));
        }
        public void TestMethod4()
        {
            Assert.AreEqual("brokeAssCode", Program.toCamel("broke     ass   code"));
        }
    }
}
