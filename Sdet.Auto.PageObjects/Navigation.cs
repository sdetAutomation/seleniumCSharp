using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Sdet.Auto.TestHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.PageObjects
{
    public class Navigation : WebDriverBase
    {
        public static void NavToWebPageUnderTest()
        {
            var navigation = Driver.Navigate();
            navigation.GoToUrl(ConfigurationManager.AppSettings["webUrl"]);
        }
    }
}
