Feature: AddCustomer

Add customer using Admin portal

@Admin
Scenario Outline: Add Customer
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
Then  User Navigates to Customer Managment page
When  User Clicks on Add Customer Button
Then  User should be on Add customer page
When  User Enters Customer details <firstName> <lastName> <email> <mobile> <country>
And   User enter details for settings '200'
When  User clicks Update Settings button
Then  Customer should get addedd

Examples:
  | username  | password      | firstName | lastname   | email            | mobile     | country |
  | validUser | validPassword | Ankit     | Chaturvedi | test11@email.com | 3421567890 | India   |