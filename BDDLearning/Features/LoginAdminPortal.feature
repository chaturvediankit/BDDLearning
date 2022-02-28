Feature: LoginAdminPortal

Login to Admin portal should happen using valid credentials only


@Smoke
Scenario Outline: Login Using Valid Credentials
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
Then  User should be logged in sussefully
Examples:
  | username  | password      |
  | validUser | validPassword |

@Admin
Scenario Outline: Login Using Invalid Credentials
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
Then  User should get <error>

Examples:
  | username    | password        | error                     |
  | validUser   | invalidPassword | Invalid Login Credentials |
  | invalidUser | invalidPassword | Invalid Login Credentials |

Scenario Outline: Logout From Admin Portal
Given User is on admin portal login page
When  User Enters credential <username> and <password>
And   User Clicks on Login button
When  User clicks on Profile Menu
And   User logout from application
Examples:
  | username  | password      |
  | validUser | validPassword |

  
