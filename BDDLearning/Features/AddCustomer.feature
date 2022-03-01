Feature: AddCustomer

Add customer using Admin portal

@tag1
Scenario Outline: Add Customer
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
Then  User Navigates to Customer Managment page
When  User Clicks on Add Customer Button
Then  User should be on Add customer page
When  User Enters Customer details <firstName> <lastName> <email> <mobile> <country> and <address>
And   User enter details for settings <balance>
When  User clicks Update Settings button
Then Customer should get addedd

Examples:
  | username  | password      | firstName | lastname | email | mobile | country | address | balance |
  | validUser | validPassword |           |          |       |        |         |         |         |