using Moq;
using NUnit.Framework;

namespace RPS.Test
{
    public class Tests
    {
        Mock match;

        [SetUp]
        public void Setup()
        {
            match = new Mock<IMatch>();
        }

        [Test]
        public void Test1()
        {
            //match.Setup(m => m.DoesSomething()).Returns(true);
        }
    }
}