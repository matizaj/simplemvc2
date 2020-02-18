using NUnit.Framework;

namespace SimpleMVC2.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //arrange 
            int a = 2, b = 2;

            //act
            var result = a + b;

            //assert
            Assert.AreEqual(4, result);
        }
    }
}