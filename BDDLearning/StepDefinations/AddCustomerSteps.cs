using System;
using BDDLearning.Hooks;
using BDDLearning.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BDDLearning.StepDefinations
{
    [Binding]
    public class AddCustomerSteps
    {
        IWebDriver driver = WebDriverClass.driver;

        [Then(@"User Navigates to Customer Managment page")]
        public void ThenUserNavigatesToCustomerManagmentPage()
        {
            DashboardPage dashboardPage = new DashboardPage(driver);
            System.Threading.Thread.Sleep(10000);
            dashboardPage.accountsLink.Click();
            System.Threading.Thread.Sleep(10000);
            dashboardPage.customersLink.Click();

        }

        [When(@"User Clicks on Add Customer Button")]
        public void WhenUserClicksOnAddCustomerButton()
        {
            CustomerManagementPage customerManagement = new CustomerManagementPage(driver);
            customerManagement.addButton.Click();
        }

        [Then(@"User should be on Add customer page")]
        public void ThenUserShouldBeOnAddCustomerPage()
        {
            AddCustomerPage addCustomer = new AddCustomerPage(driver);
            Assert.IsTrue(addCustomer.headerAddCustomer.Displayed, "Not Able to Open Add Customer page");
           
        }

        [When(@"User Enters Customer details (.*) (.*) (.*) (.*) (.*)")]
        public void WhenUserEntersCustomerDetails(string firstName,string lastname,string email, string mobile, string country)
        {
            AddCustomerPage addCustomer = new AddCustomerPage(driver);
            addCustomer.firstNameTxtField.SendKeys(firstName);
            addCustomer.lastNameTxtField.SendKeys(lastname);
            addCustomer.emailTxtField.SendKeys(email);
            addCustomer.countryDropDown.Click();
            addCustomer.selectCountry.Click();
            addCustomer.passwordTxtField.SendKeys(TestContext.Parameters.Get("validPassword"));
           
        }

        [When(@"User enter details for settings '([^']*)'")]
        public void WhenUserEnterDetailsForSettings(string balance)
        {
            AddCustomerPage addCustomer = new AddCustomerPage(driver);
            addCustomer.balanceTxtField.SendKeys(balance);

        }

        [When(@"User clicks Update Settings button")]
        public void WhenUserClicksUpdateSettingsButton()
        {
            AddCustomerPage addCustomer = new AddCustomerPage(driver);
            addCustomer.submitButton.Click();

        }

        [Then(@"Customer should get addedd")]
        public void ThenCustomerShouldGetAddedd()
        {
            CustomerManagementPage customerManagement = new CustomerManagementPage(driver);
            Assert.IsTrue(customerManagement.addButton.Displayed, "Not Redirected to Customer management");

        }




    }
}
