using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        [TestInitialize]
        public void TestIntialize() // called before execution of every test method.
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            int result = calc.Addition(10, 15);
            Assert.AreEqual(result, 25);
        }

        [TestMethod]
        public void TestSubtract()
        {
            int result = calc.Subtract(10, 15);
            Assert.AreEqual(result, -5);
        }

        [TestMethod]
        public void TestDivide()
        {
            int result = calc.Divide(10, 15);
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivideWithZero()
        {
            int result = calc.Divide(10, 0);
        }

        [TestCleanup]
        public void Cleanup()
        {
            calc = null;
        }
    }
}
