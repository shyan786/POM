Feature: Login
Test the login functionallity of application
Observe that Whether the application is accessed by auythentic user or not 

@regressiontest
Scenario Outline: Verify comBination of username and password is working properly (+ve case)

Given  I have navigated to the application
And  I enterd the valid <username> and <password> inti the respectives field 
When i press login button
Then  it should return EA pages 

Examples: 
| username  | password |
| shyan     | shyan123 |
| shyanwasi | shya453  |