using System.Reflection;
using NUnit.Framework;

namespace tests
{
    public class tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void test1()
        {
            foreach (var attribute in Assembly.GetExecutingAssembly().CustomAttributes)
                TestContext.WriteLine(attribute.ToString());

            Assert.Pass();
        }
    }
}