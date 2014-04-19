using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Models;

namespace UnitTesting.Tests.Models {
    [TestClass]
    public class CalculatorTests {

        [TestMethod]
        public void TestAddNumbers() {
            // Arrange
            var calc = new Calculator();

            // Act
            var result = calc.AddNumbers(0, 0);

            // Assert
            Assert.AreEqual(0, result);

        }

    }
}
