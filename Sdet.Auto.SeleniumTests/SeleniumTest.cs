using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.PageObjects;

namespace Sdet.Auto.SeleniumTests
{
    [TestClass]
    public class SeleniumTest
    {
        [TestMethod]
        public void TC0001_SmokeTest()
        {
            GuiHelper.OpenWebBrowser();

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
