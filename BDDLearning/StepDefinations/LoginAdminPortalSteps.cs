using System;
using BDDLearning.Hooks;
using BDDLearning.Pages;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDLearning.StepDefinations
{
    [Binding]
    public class LoginAdminPortalSteps
    {
        IWebDriver driver;
        [Given(@"User is on admin portal login page")]
        public void GivenUserIsOnAdminPortalLoginPage()
        {
            WebDriverClass webDriverClass = new WebDriverClass();
            driver=webDriverClass.OpenApplication();
           
        }

        [When(@"User Enters credential (.*) and (.*)")]
        public void WhenUserEntersValid(String username, string password)
        {
            
            LoginPage loginPage = new LoginPage(driver);
            loginPage.usernameTextField.SendKeys(TestContext.Parameters.Get(username));
            loginPage.passwordTextField.SendKeys(TestContext.Parameters.Get(password));

        }

        [When(@"User Clicks on Login button")]
        public void WhenUserClicksOnLoginButton()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.loginButton.Click();

        }

        [Then(@"User should be logged in sussefully")]
        public void ThenUserShouldBeLoggedInSussefully()
        {
            DashboardPage dashboardPage = new DashboardPage(driver);
            Assert.IsTrue(dashboardPage.dropdownMenuProfile.Displayed, "User was not on dashboard Page");
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.CloseBrowser(driver);
        }
        
        [Then(@"User should get (.*)")]
        public void ThenUserShouldGetError(String errorMessage)
        {
            LoginPage loginPage = new LoginPage(driver);
            System.Threading.Thread.Sleep(10000);
            Assert.IsTrue(loginPage.invalidError.Displayed, "No Error Message");
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.CloseBrowser(driver);            
        }
        [When(@"User clicks on Profile Menu")]
        public void WhenUserClicksOnProfileMenu()
        {
            DashboardPage dashboardPage = new DashboardPage(driver);
            dashboardPage.dropdownMenuProfile.Click();
           
        }

        [When(@"User logout from application")]
        public void WhenUserLogoutFromApplication()
        {
            System.Threading.Thread.Sleep(10000);
            DashboardPage dashboardPage = new DashboardPage(driver);
            dashboardPage.logoutButton.Click();
            System.Threading.Thread.Sleep(10000);
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(loginPage.usernameTextField.Displayed, "User not on Login Page");
            System.Threading.Thread.Sleep(10000);
            WebDriverClass webDriverClass = new WebDriverClass();
            webDriverClass.CloseBrowser(driver);
        }
    }
}
