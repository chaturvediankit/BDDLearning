using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace BDDLearning.Hooks
{
    internal class WebDriverClass:BaseClass
    {
        
        public void OpenApplication()
        {
            String browser = TestContext.Parameters.Get("browser");
            if (browser.Contains("Chrome"))
            {
                MyDriver = new ChromeDriver();
                MyDriver.Manage().Window.Maximize();
                MyDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }else if (browser.Contains("Firefox"))
            {
                MyDriver = new FirefoxDriver();
                MyDriver.Manage().Window.Maximize();
                MyDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));

            }
            else if (browser.Contains("Edge"))
            {
                MyDriver = new EdgeDriver();
                MyDriver.Manage().Window.Maximize();
                MyDriver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }

        }

        public void CloseBrowser(IWebDriver driver)
        {
            try
            {
                driver.Quit();
                Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

                foreach (var chromeDriverProcess in chromeDriverProcesses)
                {
                    chromeDriverProcess.Kill();
                }
                Console.WriteLine("Test Completes successfully");
            }
            catch (WebDriverException testClosingException)
            {
                Console.WriteLine("Driver Failed to close the browser: {0}", testClosingException.Message);
            }

        }
    }
}
