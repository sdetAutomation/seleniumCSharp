using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.PageObjects
{
    public class EmailSentPage : WebDriverBase
    {
        private static string txtMessage = "#content";

        public static void VerifyEmailSent(TestAssert testAssert, String expectedMsg)
        {
            testAssert.Pass = LoggingLibrary.CompareResult(Driver.FindElement(By.CssSelector(txtMessage)).Text, expectedMsg);
        }
    }
}
