using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mirror
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_carson()
        {
            Assert.AreEqual("nosrac", reverseString.reverse("carson"));
        }
        public void Test_nulls()
        {
            Assert.AreEqual("hll lhh", reverseString.reverse("hhl llh"));
        }
        public void Test_nulls2()
        {
            Assert.AreEqual("something", reverseString.reverse("something"));
        }
    }
}
