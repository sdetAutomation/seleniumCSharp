using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdet.Auto.TestHelper;
using System.Configuration;

namespace Sdet.Auto.PageObjects
{
    public class GuiHelper
    {
        public static void OpenWebBrowser()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["webBrowser"]);
            Console.WriteLine(ConfigurationManager.AppSettings["webUrl"]);
            //WebDriverBase.GetWebDriver(ConfigurationManager.AppSettings["webBrowser"]);
        }

        public static void CloseWebBrowser()
        {
            //WebDriverBase.driver.Close;
            //WebDriverBase.driver.quit();
        }
    }
}
