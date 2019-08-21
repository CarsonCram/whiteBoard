using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumLettersInString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(20, Program.NumLetters("Hello friend, how are you?"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0, Program.NumLetters("/@#$%^&*()1234567890.,><':;[]{}|? "));
        }
    }
}
