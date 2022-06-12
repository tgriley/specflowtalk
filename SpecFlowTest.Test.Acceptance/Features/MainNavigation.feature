Feature: Main Navigation

Scenario: User can navigate to the log in page from the home page
	Given the user is on the Homepage 
	When the user clicks on the log in link
	Then the log in page loads
	
Scenario: User can navigate to the home page from the log in page
	Given the user is on the Login page
	When the user clicks on the Home link
	Then the Home page loads