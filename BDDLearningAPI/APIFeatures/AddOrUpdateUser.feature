Feature: AddOrUpdateUser

Test Create and Update User


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