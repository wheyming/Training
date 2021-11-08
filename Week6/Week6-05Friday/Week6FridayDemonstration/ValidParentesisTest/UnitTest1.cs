using System;
using Xunit;
using Week6FridayDemonstration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidParentesisTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestForValidString()
        {
            Program p = new Program();
            var res = p.checkValidString("(())");

            Assert.IsFalse(res);
        }
    }
}
