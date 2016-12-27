using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.PageObjects
{
    public class SecureAreaPage : WebDriverBase
    {
        private static string lblMessage = "#flash";
        private static string btnLobout = ".icon-2x.icon-signout";

        public static void VerifyMessage(TestAssert testAssert, String expectedMsg)
        {

            testAssert.Pass = LoggingLibrary.CompareResultContains(Driver.FindElement(By.CssSelector(lblMessage)).Text, expectedMsg);
        }

        public static void ClickLogoutButton()
        {
            Driver.FindElement(By.CssSelector(btnLobout)).Click();
        }
    }
}
