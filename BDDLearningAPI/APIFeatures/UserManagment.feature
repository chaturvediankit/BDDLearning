Feature: UserManagment

User management using get User, Create user, update user and delete user

@Users
Scenario Outline: Validate get user API
	Given User Enters user id <id>
	When  User send get user request
	Then  Validate user details <firstName> <lastName> and Http response code <httpCode>
Examples: 
| id | firstName | lastName | httpCode |
| 2  | Janet     | Weaver   | 200      |

@Users
Scenario Outline: Validate create user API
Given  User eneters job <job>
And    User enters role <role>
When   User send create user request
Then   User should get created
Examples: 
| job | role |
| QA  | TEST |
@Users
Scenario Outline: Validate update user API
Given  User eneters job <job>
And    User enters role <role>
Given  user want to update user id <id>
When   User send update user request
Then   User should get updated
Examples: 
| job | role | id |
| QA  | TEST | 2  |

@Users
Scenario Outline: Validate delete user API
	Given User Enters user id <id>
	When  User send delete user request
	Then  Validate user is deleted <httpCode>
Examples: 
| id | httpCode |
| 2  | 204      |

