Feature: Win game
	In order to win a hand of Blackjack
	As a player 
	I must be closer to 21 than the dealer and not go bust

Scenario: Player Gets blackjack with two cards
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Ace	    |
	  | Diamonds | Eight    |
	  | Clubs	 | Ten		|    
	  | Hearts	 | Two		|      	  	  
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button
	Then the player should win the game

Scenario: Dealer Gets blackjack with two cards
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Diamonds | Ace	    |
	  | Hearts	 | Two		|
	  | Clubs	 | Ten		|    	  	  	  
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button
	When I stick
	Then the player should lose the game
	
Scenario: Both player and dealer get blackjack so game ends in draw
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the deck contains the following cards:
	  | Suit	| Value	|  
	  | Hearts	| Ace	|
	  | Spades	| Ten	|
	  | Hearts	| Ten	|	  	  	  
	  | Clubs	| Ace	|          
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	    
	Then the game should be drawn	

Scenario: Player sticks at 20 and dealer sticks at 19 so players wins
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the dealers has dealt me in
	And my hand contains the following cards:
	  | Suit	| Value	|
      | Hearts	| Ten	|
      | Clubs	| King	|
	And the dealers hand contains the following cards:
	  | Suit	| Value	|
      | Spades	| Ten	|  
	  | Hearts	| Six	|  
	And the deck contains the following cards:
	  | Suit		| Value	|    
	  | Diamonds	| Three	|   
    And I have navigated to the game play screen to play a hand	     	
	When I stick
	Then the player should win the game	

Scenario: Player sticks at 16 and dealer sticks at 19 so players wins
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the dealers has dealt me in
	And my hand contains the following cards:
	  | Suit	| Value	|
      | Hearts	| Ten	|
      | Clubs	| Six	|
	And the dealers hand contains the following cards:
	  | Suit	| Value	|
      | Spades	| Ten	|  
	  | Hearts	| Five	|  
	And the deck contains the following cards:
	  | Suit		| Value	|    
	  | Diamonds	| Four	|   
    And I have navigated to the game play screen to play a hand	     	
	When I stick
	Then the player should lose the game

Scenario: Player sticks and dealer busts so player wins
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the dealers has dealt me in
	And my hand contains the following cards:
	  | Suit	| Value	|
      | Hearts	| Ten	|
      | Clubs	| Jack	|
	And the dealers hand contains the following cards:
	  | Suit	| Value	|
      | Spades	| Ten	|  
	  | Hearts	| Six	|  
	And the deck contains the following cards:
	  | Suit		| Value	|    
	  | Diamonds	| Ten	|   
    And I have navigated to the game play screen to play a hand	     	
	When I stick
	Then the player should win the game	
