using System.Reflection;
using NUnit.Framework;

namespace tests
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
            foreach (var attribute in Assembly.GetExecutingAssembly().CustomAttributes)
                TestContext.WriteLine(attribute.ToString());

            Assert.Pass();
        }
    }
}