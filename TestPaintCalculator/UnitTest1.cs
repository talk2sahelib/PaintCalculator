using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaintCalculator;

namespace TestPaintCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           Program.PaintCalculationInput(12, 10, 11);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program.PaintCalculationInput(12.5, 10.5, 11.5);
        }


    }
}
