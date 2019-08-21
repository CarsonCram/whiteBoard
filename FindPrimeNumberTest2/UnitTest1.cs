using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindPrimeNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.findPrime(113));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsFalse(Program.findPrime(1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(Program.findPrime(11));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(Program.findPrime(15));
        }
    }
}
