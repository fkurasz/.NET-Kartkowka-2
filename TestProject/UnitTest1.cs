using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(15 == 3 * 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 10;
            int b = 6 + 2 * 2;
            Assert.AreEqual(a,b);
        }
    }
}
