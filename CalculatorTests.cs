using CalculatorProj;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        
        [Test, Description("Sum of two numbers")]
        public void CheckSumOfNumbers_01()
        {
            Assert.AreEqual(20, calculator.SumNumbers(10, 10));
        }

        [Test, Description("Sum of two numbers")]
        public void CheckSumOfNumbers_02()
        {
            Assert.AreEqual(15, calculator.SumNumbers(10, 10));
        }

        [Test, Description("Multiply numbers")]
        public void CheckMultiplyOfNumbers_01()
        {
            Assert.AreEqual(20, calculator.MultiplyNumbers(4, 5));
        }

        [Test, Description("Multiply numbers")]
        public void CheckMultiplyOfNumbers_02()
        {
            Assert.AreEqual(15, calculator.MultiplyNumbers(4, 5));
        }

        [Test, Description("Multiply numbers")]
        public void ChekSubstractOfNumbers_01()
        {
            Assert.AreEqual(20, calculator.SubstractNumbers(50, 30));
        }

        [Test, Description("Multiply numbers")]
        public void ChekSubstractOfNumbers_02()
        {
            Assert.AreEqual(15, calculator.SubstractNumbers(50, 30));
        }

        [Test, Description("Multiply numbers")]
        public void CheckDivideOfNumbers_01()
        {
            Assert.AreEqual(20, calculator.DivideNumbers(40, 2));
        }

        [Test, Description("Multiply numbers")]
        public void CheckDivideOfNumbers_02()
        {
            Assert.AreEqual(15, calculator.DivideNumbers(40, 2));
        }
    }
}
