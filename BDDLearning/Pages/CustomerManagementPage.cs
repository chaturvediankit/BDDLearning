using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDDLearning.Pages
{
    public class CustomerManagementPage
    {
        IWebDriver driver;
        public CustomerManagementPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement addButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        
    }
}
