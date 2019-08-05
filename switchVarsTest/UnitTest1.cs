using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace switchVars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositiveNums()
        {
            Assert.AreEqual( "6, 5", Program.vars(5, 6));
        }
        [TestMethod]
        public void TestNegativeNums()
        {
            Assert.AreEqual("-3000, 280", Program.vars(280, -3000));
        }
        [TestMethod]
        public void TestTwoNegatives()
        {
            Assert.AreEqual("-6, -7", Program.vars(-7, -6));
        }
    }
}
