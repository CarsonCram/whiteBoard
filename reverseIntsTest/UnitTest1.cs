using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace reverseInts
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositives()
        {
            Assert.AreEqual( 3345, reverse.Num(5433) );
        }
    }
}
