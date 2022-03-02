using System;
using TechTalk.SpecFlow;

namespace BDDLearning.StepDefinations
{
    [Binding]
    public class AddCustomerSteps
    {
        

        [When(@"User Navigates to Customer Dashboard page")]
        public void WhenUserNavigatesToCustomerDashboardPage()
        {
           
        }
        [Then(@"User Navigates to Customer Managment page")]
        public void ThenUserNavigatesToCustomerManagmentPage()
        {
           
        }

        [When(@"User Clicks on Add Customer Button")]
        public void WhenUserClicksOnAddCustomerButton()
        {
            
        }

        [Then(@"User should be on Add customer page")]
        public void ThenUserShouldBeOnAddCustomerPage()
        {
           
        }

        [When(@"User Enters Customer details  (.*) (.*) (.*) (.*) (.*) and (.*)")]
        public void WhenUserEntersCustomerDetails(string firstName,string lastname,string email, string mobile, string country, string adress)
        {
           
        }

        [When(@"User enter details for settings '([^']*)'")]
        public void WhenUserEnterDetailsForSettings(string balance)
        {
            
        }

        [When(@"User clicks Update Settings button")]
        public void WhenUserClicksUpdateSettingsButton()
        {
          
        }

        [Then(@"Customer should get addedd")]
        public void ThenCustomerShouldGetAddedd()
        {
            
        }




    }
}
