using OpenQA.Selenium;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sdet.Auto.PageObjects
{
    public class ForgetPasswordPage : WebDriverBase
    {
        private static string txtEmail = "#email";
        private static string btnRetrievePassword = ".icon-2x.icon-signin";

        public static void EnterEmail(String email)
        {
            Driver.FindElement(By.CssSelector(txtEmail)).SendKeys(email);
        }

        public static void ClickRetrieveButton()
        {
            Driver.FindElement(By.CssSelector(btnRetrievePassword)).Click();
        }
    }
}
