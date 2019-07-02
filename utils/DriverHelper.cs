using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Test.utils
{



    public class DriverHelper
    {



        public static IWebDriver driver;

        public static IWebDriver getInstance()
        {
            if (driver == null)
            {

                string projectDirectory = Directory.GetParent("test").Parent.FullName;
                driver = new ChromeDriver(projectDirectory.Replace("/bin", "/Drivers"));
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            return driver;
        }
        public static void ClickOnElement(By selector)
        {
            getInstance().FindElement(selector).Click();
        }

        public static void SetText(By selector, String text)
        {
            getInstance().FindElement(selector).SendKeys(text);
        }

        public static void NavigateToUlr(String text)
        {
            getInstance().Navigate().GoToUrl(text);
        }

        public static String getText(By selector)
        {
            return getInstance().FindElement(selector).Text;
        }

        public static void quit()
        {
            getInstance().Quit();
        }
    }
}
