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
    public class WebDriverBase
    {
        public static IWebDriver driver;

        public static void GetWebDriver(string browser)
        {
            if (browser == "chrome")
            {
                IoLibrary.WriteLine("Launching Chrome Browser.");
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--start-maximized");
                options.AddArguments("--disable-extensions");
                driver = new ChromeDriver(IoLibrary.GetBinPath(), options);
                driver.Manage().Cookies.DeleteAllCookies();
            }
            else if (browser == "firefox")
            {
                // todo: add proper ff loation code..  System.setProperty("webdriver.gecko.driver", "src/main/resources/geckodriver");
                IoLibrary.WriteLine("Launching Firefox Browser.");
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
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

                //todo:  add grid code here...

                driver = new RemoteWebDriver(capabilities);

                //try
                //{
                //    driver = new RemoteWebDriver(new URL(gridUrl), capabilities);
                //}
                //catch (MalformedURLException e)
                //{
                //    e.printStackTrace();
                //}
                //driver.Manage().Window().Maximize();
            }
            else
            {
                throw new Exception(string.Format("Browser Type {0}, not Found, please add additional code for this desired WebDriver Type.", browser));
            }
        }
    }
}
