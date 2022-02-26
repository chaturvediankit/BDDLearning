using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BDDLearning.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement usernameTextField => driver.FindElement(By.Name("email"));
        public IWebElement passwordTextField => driver.FindElement(By.Name("password"));
        public IWebElement loginButton => driver.FindElement(By.XPath("//span[text()='Login']"));
        public IWebElement invalidError => driver.FindElement(By.XPath("//div[text()='Invalid Login Credentials']"));
        public IWebElement logoutButton => driver.FindElement(By.XPath("//*[@id='logout']/a"));

        public void LoginApplication(string userName, string passWord)
        {
            try
            {
                usernameTextField.Clear();
                usernameTextField.SendKeys(userName.Trim());
                passwordTextField.Clear();
                passwordTextField.SendKeys(passWord.Trim());
                loginButton.Click();
            }
            catch (Exception E)
            {
                Console.WriteLine("Test Fail: did not enter username and password  : {0}", E.Message);
                throw;
            }
        }

    }
}
