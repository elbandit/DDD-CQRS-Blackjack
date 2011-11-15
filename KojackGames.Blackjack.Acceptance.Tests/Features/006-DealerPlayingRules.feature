Feature: Dealer Rules
	In order to give a player a sporting chance
	As a dealer 
	I will hit on any score below 17 and stand on any score of 17 and above

Scenario: Dealer plays until he gets over 17
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the dealers has dealt me in
	And my hand contains the following cards:
	| Suit		| Value		|
	| Hearts	| Ten		|
	| Clubs		| Jack		|
	And the dealers hand contains the following cards:
	| Suit		| Value		|
	| Spades	| Five		|  
	| Hearts	| Six		|	  
	And the deck contains the following cards:
	| Suit		| Value		|    
	| Diamonds	| Two		|   
	| Diamonds	| Four		|   
	| Clubs		| Two		| 
	| Diamonds	| Seven		|   
	And I have navigated to the game play screen to play a hand	     	
	When I stick
	Then the dealers hand should show the following cards:	 
	| card				|
    | Five of Spades	|
    | Six of Hearts		|
	| Two of Diamonds	|
	| Four of Diamonds	|
