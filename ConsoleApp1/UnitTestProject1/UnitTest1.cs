using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 4;
            int resultSum = ConsoleApp1.Program.Mycalc.Sum(x);
         
            Assert.AreEqual(64, resultSum);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            int x = 4;
           
            int resultBul = ConsoleApp1.Program.Mycalc.Bul(x);
           
            Assert.AreEqual(96, resultBul);
        }
    }
}
