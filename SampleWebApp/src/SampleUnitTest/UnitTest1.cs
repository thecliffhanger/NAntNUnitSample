using System;
using NUnit.Framework;

namespace SampleUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.IsTrue(true);
        }

        [Test, ExpectedException]
        public void TestMethod3()
        {
            throw new Exception("Exception");
        }

        [Test, Ignore]
        public void TestMethod4()
        {
            throw new Exception("Exception");
        }
    }
}
