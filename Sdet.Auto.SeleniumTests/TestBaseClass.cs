using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.TestHelper;

namespace Sdet.Auto.SeleniumTests
{
    [TestClass]
    public class TestBaseClass
    {
        public TestAssert TestAssert;

        [TestInitialize]
        public void MyTestInitialize()
        {
            TestAssert = new TestAssert();
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            Assert.IsTrue(TestAssert.Pass);
        }
    }
}
