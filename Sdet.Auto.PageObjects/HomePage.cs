using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.PageObjects
{
    public class HomePage : WebDriverBase
    {
        private static string txtHeader = "#content h1";
        private static string linkForgetPassword = "[href=\'/forgot_password\']";
        private static string linkFormAuthentication = "[href=\'/login\']";

        public static void ClickForgetPassword()
        {
            Driver.FindElement(By.CssSelector(linkForgetPassword)).Click();
        }

        public static void ClickFormAuthentication()
        {
            Driver.FindElement(By.CssSelector(linkFormAuthentication)).Click();
        }

        public static void VerifyOnHomePage(TestAssert testAssert)
        {
            string headerText = Driver.FindElement(By.CssSelector(txtHeader)).Text;
            testAssert.Pass = LoggingLibrary.CompareResult(headerText, "Welcome to the Internet");
        }
    }
}
