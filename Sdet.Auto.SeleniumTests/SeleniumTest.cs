using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sdet.Auto.PageObjects;
using Sdet.Auto.TestHelper;
using System.Threading;

namespace Sdet.Auto.SeleniumTests
{
    [TestClass]
    public class SeleniumTest : TestBaseClass
    {
        [TestMethod]
        public void TC0001_SmokeTest()
        {
            GuiHelper.OpenWebBrowser();
            Navigation.NavToWebPageUnderTest();
            HomePage.VerifyOnHomePage(TestAssert);
            GuiHelper.CloseWebBrowser();
        }

        [TestMethod]
        public void TC0002_ForgetPasswordTest()
        {
            const string email = "sdet.testautomation@gmail.com";
            const string expectedMsg = "Your e-mail's been sent!";

            GuiHelper.OpenWebBrowser();
            Navigation.NavToWebPageUnderTest();
            HomePage.ClickForgetPassword();
            ForgetPasswordPage.EnterEmail(email);
            ForgetPasswordPage.ClickRetrieveButton();
            EmailSentPage.VerifyEmailSent(TestAssert, expectedMsg);
            GuiHelper.CloseWebBrowser();
        }

        [TestMethod]
        public void TC0003_FormAuthentication()
        {
            const string userId = "tomsmith";
            const string password = "seleniumCSharpPassword!";
            const string expectedLoginMsg = "You logged into a secure area!";
            const string expectedLogoutMsg = "You logged out of the secure area!";

            GuiHelper.OpenWebBrowser();
            Navigation.NavToWebPageUnderTest();
            HomePage.ClickFormAuthentication();
            LoginPage.EnterCredentials(userId, password);
            SecureAreaPage.VerifyMessage(TestAssert, expectedLoginMsg);
            SecureAreaPage.ClickLogoutButton();
            LoginPage.VerifyMessage(TestAssert, expectedLogoutMsg);
            GuiHelper.CloseWebBrowser();
        }

        [TestMethod]
        public void TC0004_FormAuthenticationBadInfo()
        {
            const string userId = "sdetAutomatiom";
            const string password = "pass@word";
            const string expectedMsg = "Your username is invalid!";

            GuiHelper.OpenWebBrowser();
            Navigation.NavToWebPageUnderTest();
            HomePage.ClickFormAuthentication();
            LoginPage.EnterCredentials(userId, password);
            LoginPage.VerifyMessage(TestAssert, expectedMsg);
            GuiHelper.CloseWebBrowser();
        }
    }
}
