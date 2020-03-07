using System;
using NUnit.Framework;
using CalculatorApp;

namespace CalculatorTest
{
    public class PlaygroundTest
    {
        [Test]
        public void TestDoesNotFail()
        { 
            Playground.Test();
        }
    }
}