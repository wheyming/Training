using Moq;
using NUnit.Framework;
using Week6FridayDemonstration;

namespace NUnitTest
{
    public class Tests
    {
        private Mock<ITakeInput> _mocktakeInput;

        [SetUp]
        public void Setup()
        {
            _mocktakeInput = new Mock<ITakeInput>();
        }

        [Test]
        public void TestCheckStringMethod()
        {
            
            _mocktakeInput.Setup(t => t.TakeInputMethod()).Returns("{}{}{}{}");


            CheckString checkString = new CheckString(_mocktakeInput.Object);
            var res = checkString.checkValidString();
            
            Assert.True(res);
        }

        [Test]
        [TestCase("{}{{}")]
        [TestCase("")]
        [TestCase("{((({")]
        public void TestCheckStringMethodIsFalse(string str)
        {

            _mocktakeInput.Setup(t => t.TakeInputMethod()).Returns(str);


            CheckString checkString = new CheckString(_mocktakeInput.Object);
            var res = checkString.checkValidString();

            Assert.False(res);
        }

        [TearDown]
        public void Teardown()
        {
            _mocktakeInput = null;
        }
    }
}