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
            var result = Calculator.Run(new [] {"multiply", "50", "5"});
            
            Assert.AreEqual(250, result);
        }
        
        [Test]
        public void DivideNumbers()
        {
            var result = Calculator.Run(new string[] {"divide", "50", "5"});
            
            Assert.AreEqual(10, result);
        }

        [Test]
        public void SubtractNumber()
        {
            var result = Calculator.Run(new string[] {"subtract", "50", "5"});
            
            Assert.AreEqual(45, result);
        }

        [Test]
        public void AddNumbers()
        {
            var result = Calculator.Run(new string[] {"sum", "50", "5"});
            Assert.AreEqual(55, result);
        }

        [Test]
        public void UnclearNumber()
        {
            TestDelegate runThatFails = () => Calculator.Run(new string[] {"fail", "50", "5"});
            Assert.Throws<ArgumentException>(runThatFails);
        }
    }
}