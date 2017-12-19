using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator5;

namespace UnitTestProject1
{
    [TestClass]
    public class TestCalculator
    {

        private readonly TokidokiFacturator calculator;
        public TestCalculator()
        {
            calculator = new TokidokiFacturator(new BeersHourFake());
        }

        [TestMethod]
        public void GivenTheTwoTokidokisWorks_WhenCalculate_ThenHaveTheCorrectNumerOfBeers()
        {
            // Arrange
            var unicornHours = 5;
            var donatellaHours = 3;

            // Action
            var beers = calculator.calcular(unicornHours, donatellaHours);

            // Assert
            Assert.AreEqual(18, beers);

        }

        [TestMethod]
        public void GivenNoneTokidokisWorks_WhenCalculate_ThenAreNoBeers()
        {
            // Arrange
            var unicornHours = 0;
            var donatellaHours = 0;

            // Action
            var beers = calculator.calcular(unicornHours, donatellaHours);

            // Assert
            Assert.AreEqual(0, beers);

        }

        [TestMethod]
        public void GivenTokidokisWorksInNegative_WhenCalculate_ThenAreNoBeers()
        {
            // Arrange
            var unicornHours = -5;
            var donatellaHours = 0;

            // Action
            var beers = calculator.calcular(unicornHours, donatellaHours);

            // Assert
            Assert.AreEqual(0, beers);

        }
    }
}
