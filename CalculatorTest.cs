using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDailyExercise02
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator calc = new Calculator();
        
        [Test]
        public void countTestOnAdd()
        {
            Assert.AreEqual(10, calc.Add(5, 5));
        }

        [Test]
        public void countTestOnSub()
        {
            Assert.AreEqual(20, calc.Subtract(30, 10));
        }

        [Test]
        public void countTestOnMulti()
        {
            Assert.AreEqual(20, calc.Multiply(30, 10));
        }

        [Test]
        public void countTestOnDivide()
        {
            Assert.AreEqual(2, calc.Divide(10, 5));
        }

        [Test]
        public void countTestOnPrime()
        {
            Assert.AreEqual(3, calc.isPrime(3));
        }
    }
}
