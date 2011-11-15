Feature: Manage Member Account
	In order to keep my details up to date
	As a member
	I should be able to be able to manage my account

Scenario: Update name
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have navigated to the edit name screen
	When update my name to "Scotty"
	And click update
	Then I should be logged in to my account section
	And a message should say hello "Scotty"
	 