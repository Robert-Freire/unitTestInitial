using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator3;

namespace CalculatorUnitTest
{
   // [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void VaBien()
        {
            var calculator = new TokidokiFacturator();
            Assert.IsTrue(calculator.calcular(5, 3) == 18);

        }

        [TestMethod]
        public void VaMuyBien()
        {
            var calculator = new TokidokiFacturator();
            Assert.IsTrue(calculator.calcular(0, 0) == 0);
            Assert.IsTrue(calculator.calcular(-5, 0) == 0);
        }
    }
}
