Feature: AddCustomer

Add customer using Admin portal

@tag1
Scenario Outline: Add Customer
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
When  User Navigates to Customer Dashboard page

Examples:
  | username  | password      | customerName | customerEmail |
  | validUser | validPassword |              |               |