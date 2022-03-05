Feature: AddOrUpdateUser

Test Create and Update User


@Users
Scenario Outline: Validate create user API
Given  User eneters job <job>
And    User enters name <name>
When   User send create user request
Then   User should get created
Examples: 
| job | name |
| QA  | TEST |
@Users
Scenario Outline: Validate update user API
Given  User eneters job <job>
And    User enters name <name>
Given  user want to update user id <id>
When   User send update user request
Then   User should get updated
Examples: 
| job | name | id |
| QA  | TEST | 2  |