using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace BDDLearning.Hooks
{
   public class WebDriverClass
    {

        public static IWebDriver driver;

        public IWebDriver OpenApplication()
        {
            String browser = TestContext.Parameters.Get("browser");
            if (browser.Contains("Chrome"))
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
                driver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }else if (browser.Contains("Firefox"))
            {
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));

            }
            else if (browser.Contains("Edge"))
            {
                driver = new EdgeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(TestContext.Parameters.Get("url"));
            }
            return driver;

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
