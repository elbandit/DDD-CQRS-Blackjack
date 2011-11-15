Feature: Stand
	In order to avoid going bust
	As a player
	I should be able to stand (keep your existing hand as it is) for each hand in turn

Scenario: Option to stick
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the dealers has dealt me in
	And my hand contains the following cards:
	  | Suit	| Value	|
      | Hearts	| Two	|
      | Clubs	| Six	|
	And the dealers hand contains the following cards:
	  | Suit	| Value	|
      | Hearts	| Ten	|  
	  | Hearts	| Three	|  
    When I navigate to the game play screen	
	Then I should given the option to stick