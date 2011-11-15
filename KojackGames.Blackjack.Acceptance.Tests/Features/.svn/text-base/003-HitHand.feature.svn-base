Feature: Hit
	In order to achieve 21 
	As a player
	I should be able to Hit and receive an extra card from the pack

Scenario: Option to Hit
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
	Then I should given the option to hit

Scenario: Hit
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
	And the deck contains the following cards:
	  | Suit	| Value	|    
	  | Hearts	| Four	|        
	  | Hearts	| Five	|  
	And I have navigated to the game play screen	
	When I hit 
	Then my hand should show the following cards:
	  | card			|
      | Two of Hearts	|
      | Six of Clubs	|
	  | Four of Hearts	|
	 
