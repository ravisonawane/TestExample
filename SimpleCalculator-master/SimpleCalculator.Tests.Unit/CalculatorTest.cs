using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "+");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            double result = Calculator.Calculate(3, 2, "-");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "*");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            double result = Calculator.Calculate(4, 2, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "%");
        }

        [TestMethod]
        public void AddTwoNumbersWithAdd()
        {
            double result = Calculator.Calculate(12, 3, InputFormatter.FormatOperator("add"));
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWithSecondLargest()
        {
            double result = Calculator.Calculate(5, 8, InputFormatter.FormatOperator("subtract"));
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersFirstLargest()
        {
            double result = Calculator.Calculate(8, 2, InputFormatter.FormatOperator("subtract"));
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersWithMultiply()
        {
            double result = Calculator.Calculate(4, 2, InputFormatter.FormatOperator("multiply"));
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void DivideTwoNumbersWithFirstLargest()
        {
            double result = Calculator.Calculate(4, 2, InputFormatter.FormatOperator("divide"));
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbersWithSecondLargest()
        {
            double result = Calculator.Calculate(2, 4, InputFormatter.FormatOperator("divide"));
            Assert.AreEqual(2, result);
        }
    }
}
