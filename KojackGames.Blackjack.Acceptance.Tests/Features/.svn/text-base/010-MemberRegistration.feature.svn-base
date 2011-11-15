Feature: Member Registration
	In order to gamble 
	As a player
	I should be able to register my details

Scenario: Add an account
	Given I have navigated to the registration page
	And I have entered "Scott@elbandit.co.uk" for my email
	And I have entered "Scott" for my name
	And I have entered "Cheese@123" for my password
	When I press register
	Then I should be logged in to my account section
	And a message should say hello "Scott"

Scenario: Disable access to unauthenticated users
	Given that I have not logged In 
	When I navigate to the account page
	Then I should be redirected to login	

Scenario: log in
	Given that I have an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	  
	And I navigate to the login page
	And I have entered "Scott@elbandit.co.uk" for my email	
	And I have entered "Cheese@123" for my password
	When I click login
	Then I should be logged in to my account section
	And a message should say hello "Scott"