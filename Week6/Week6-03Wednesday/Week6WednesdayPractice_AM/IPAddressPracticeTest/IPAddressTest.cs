using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Week6WednesdayPractice_AM;

namespace IPAddressPracticeTest
{
    [TestClass]
    public class IPAddressTest
    {
        [TestMethod]
        public void TestMethod1ForValidInput()
        {
            var result = Program.checkipAddress("192.1.1.254");

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("192.135..1")]
        [DataRow("-100.2.246.1")]
        [DataRow("2000.135.256.1")]
        [DataRow("")]
        public void TestMethod1ForInvalidInput(string input)
        {
            var result = Program.checkipAddress(input);

            Assert.IsFalse(result);
        }
    }
}
