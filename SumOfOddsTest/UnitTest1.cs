using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfOdd;
namespace SumOfOddTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumOfOddsTest10()
        {
            Assert.AreEqual(25, OddSum.SumOfOdd(10));
        }
    }
}
