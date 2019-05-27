using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.UnitTest
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Calculator();
        }

        [TestCase(2, 2, 4)]
        [TestCase(2.6, -2, 0.6)]
        [TestCase(-2, -6, -8)]
        public void CalculatorAdd_AddAAndB_returnsResult(double a, double b, double result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result).Within(0.01));
        }

        [TestCase(2, 2, 0)]
        [TestCase(-4, -2, -2)]
        [TestCase(2.5, 0.5, 2)]
        public void CalculatorSubtract_SubtractAWithB_returnsResult(double a, double b, double result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result).Within(0.01));
        }

        [TestCase(2, 5, 10)]
        [TestCase(-2, 4, -8)]
        [TestCase(3.5, 3.5, 12.25)]
        public void CalculatorMultiply_MultiplyAAndB_returnsResult(double a, double b, double result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result).Within(0.01));
        }

        [TestCase(10, 1, 10)]
        [TestCase(-20, 1, -20)]
        [TestCase(1.5, 1, 1.5 )]
        public void CalculatorPower_ExpToX_returnsResult(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result).Within(0.01));
        }


    }
}
