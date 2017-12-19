using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator3;

namespace UnitTestProject4
{

//[TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void GivenTheTwoTokidokisWorks_WhenCalculate_ThenHaveTheCorrectNumerOfBeers()
            {
                // Arrange
                var unicornHours = 5;
                var donatellaHours = 3;
                var calculator = new TokidokiFacturator();

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
                var calculator = new TokidokiFacturator();

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
                var calculator = new TokidokiFacturator();

                // Action
                var beers = calculator.calcular(unicornHours, donatellaHours);

                // Assert
                Assert.AreEqual(0, beers);

            }

        }
    }
