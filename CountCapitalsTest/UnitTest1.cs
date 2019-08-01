using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountCapitals;

namespace WhiteBoardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCountCapitalsStarWars()
        {
            Assert.AreEqual(2, UpperCase.CountCapitals("Star Wars"));
        }
    }
}
