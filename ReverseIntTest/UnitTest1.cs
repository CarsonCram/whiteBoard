using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReverseInt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositives()
        {
            Assert.AreEqual(345, GetReverse.ReverseThatInt(543));
        }
        [TestMethod]
        public void TestNegatives()
        {
            Assert.AreEqual(345, GetReverse.ReverseThatInt(-543));
        }
        [TestMethod]
        public void TestNegatives()
        {
            Assert.AreEqual(345, GetReverse.ReverseThatInt(-543));
        }
    }
}
