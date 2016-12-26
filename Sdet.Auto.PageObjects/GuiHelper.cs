using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Sdet.Auto.TestHelper;

namespace Sdet.Auto.PageObjects
{
    public class GuiHelper : TestHelper.WebDriverBase
    {
        public static void OpenWebBrowser()
        {
            WebDriver.GetWebDriver(ConfigurationManager.AppSettings["webBrowser"]);
        }

        public static void CloseWebBrowser()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
