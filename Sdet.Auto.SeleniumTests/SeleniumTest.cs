using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.PageObjects;
using Sdet.Auto.TestHelper;
using System.Threading;

namespace Sdet.Auto.SeleniumTests
{
    [TestClass]
    public class SeleniumTest
    {
        [TestMethod]
        public void TC0001_SmokeTest()
        {
            GuiHelper.OpenWebBrowser();
            Thread.Sleep(3000);

        }

        [TestMethod]
        public void TC0002_ForgetPasswordTest()
        {
        }

        [TestMethod]
        public void TC0003_FormAuthentication()
        {
        }

        [TestMethod]
        public void TC0004_FormAuthenticationBadInfo()
        {
        }
    }
}
