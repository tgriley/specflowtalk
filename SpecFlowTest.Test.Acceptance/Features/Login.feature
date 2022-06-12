Feature: Login

@Authentication
Scenario: Registered user attempts to log in 
	Given the user is on the Login page
	Then the page title should be Log in
	When the user enters 'valid@email.address' in the email address field
	And the user enters 'Password01!' in the password field
	And the user clicks on the log in button
#	Then the user should get a success message
