using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Journals_Tests
{
    public class WebDriver
    {
        private WebDriver() { }
        private static IWebDriver driver;
        public static IWebDriver getDriver
        {
            get
                {
                if (driver == null)
                {
                    driver = new ChromeDriver(@"D:\");
                    driver.Manage().Window.Maximize();
                }
                return driver;
            }
        }

       public static void KillDriver()
        {
            driver.Quit();
            driver = null;
        }
    }
}


