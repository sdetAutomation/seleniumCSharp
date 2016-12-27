using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.PageObjects
{
    public class LoginPage : WebDriverBase
    {
        private static string txtUsername = "#username";
        private static string txtPassword = "#password";
        private static string btnLogin = ".fa.fa-2x.fa-sign-in";
        private static string lblMessage = "#flash";

        public static void EnterCredentials(string userId, string password)
        {
            Driver.FindElement(By.CssSelector(txtUsername)).SendKeys(userId);
            Driver.FindElement(By.CssSelector(txtPassword)).SendKeys(password);
            Driver.FindElement(By.CssSelector(btnLogin)).Click();
        }

        public static void VerifyMessage(TestAssert testAssert, String expectedMsg)
        {
            testAssert.Pass = LoggingLibrary.CompareResultContains(Driver.FindElement(By.CssSelector(lblMessage)).Text, expectedMsg);
        }
    }
}
