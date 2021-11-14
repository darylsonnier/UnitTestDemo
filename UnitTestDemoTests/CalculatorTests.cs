using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            Calculator calc = new Calculator();
            double sum = calc.Sum(2, 4);
            Assert.AreEqual(sum, 6);
        }

        [TestMethod()]
        public void SubTest()
        {
            Calculator calc = new Calculator();
            double dif = calc.Sub(4, 2);
            Assert.AreEqual(dif, 2);
        }

        [TestMethod()]
        public void MulTest()
        {
            Calculator calc = new Calculator();
            double prod = calc.Mul(2, 2);
            Assert.AreEqual(prod, 4);
        }

        [TestMethod()]
        public void DivTest()
        {
            Calculator calc = new Calculator();
            double quo = calc.Div(6, 3);
            Assert.AreEqual(quo, 2);
        }
    }
}