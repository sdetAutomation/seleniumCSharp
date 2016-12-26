using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdet.Auto.TestHelper
{
    public class WebDriver
    {
        public static IWebDriver Driver;

        public static void GetWebDriver(string browser)
        {
            if (browser == "chrome")
            {
                IoLibrary.WriteLine("Launching Chrome Browser.");
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AddArguments("--disable-extensions");
                Driver = new ChromeDriver(IoLibrary.GetBinPath(), options);
                Driver.Manage().Cookies.DeleteAllCookies();
            }
            else if (browser == "firefox")
            {
                // todo: add proper ff loation code..  System.setProperty("webdriver.gecko.driver", "src/main/resources/geckodriver");
            }
            else if (browser == "seleniumGrid")
            {
                IoLibrary.WriteLine("Launching Browser Using Selenium Grid - Chrome Browser.");

                const string gridUrl = "http://y75EbcWLcnPNI0p8sZBQTcTUGj5PCOl0:LhvNjhomu4Z3Ue2d3tTMwDx3MtJe7V5I@SESYNPZ6.gridlastic.com:80/wd/hub";
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AddArguments("--disable-extensions");
                DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
                capabilities.SetCapability(ChromeOptions.Capability, options);
                Driver = new RemoteWebDriver(capabilities);
            }
            else
            {
                throw new Exception(string.Format("Browser Type {0}, not Found, please add additional code for this desired WebDriver Type.", browser));
            }
        }
    }
}
