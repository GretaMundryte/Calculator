using System;
using NUnit.Framework;
using Persons;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MultipliesNumbers()
        { 
            var calculator1 = new Calculator();
            var result = calculator1.Run("*", 50, 5);
            
            Assert.AreEqual(250, result);
        }
        
        [Test]
        public void DivideNumbers()
        {
            var result = new Calculator().Run("/", 50, 5);
            
            Assert.AreEqual(10, result);
        }

        [Test]
        public void DivisionByZero()
        {
            TestDelegate runThatFails = () => new Calculator().Run("/", 50, 0);
            Assert.Throws<ArgumentException>(runThatFails);
        }

        [Test]
        public void SubtractNumber()
        {
            var result = new Calculator().Run("-", 50, 5);
            
            Assert.AreEqual(45, result);
        }

        [Test]
        public void AddNumbers()
        {
            var result = new Calculator().Run("+", 50, 5);
            Assert.AreEqual(55, result);
        }

        [Test]
        public void UnclearNumber()
        {
            var calculatorException = new Calculator();
            calculatorException.ThrowErrors = true;
            TestDelegate runThatFails = () => calculatorException.Run("fail", 50, 5);
            Assert.Throws<ArgumentException>(runThatFails);
        }

        [Test]
        public void ReturnsZeroOnInvalidAction()
        {
            var zeroCalculator = new Calculator();
            zeroCalculator.ThrowErrors = false;
            var result = zeroCalculator.Run("asda",3, 2);
            
            Assert.AreEqual(0, result);
        }
    }
}