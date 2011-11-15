Feature: Get involved in a game
	In order to start a new hand
	As a player
	I must make a bet

Scenario: Make a bet
    Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have navigated to the game play screen to play a hand	
	And I have "10" dollars in my pot
	When I click on the bet button
	Then I should see the deal button
	And my pot should show "$5.00" dollars

Scenario: Doesnt have enough money to bet
    Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have "0" dollars in my pot	
	And I have navigated to the game play screen to play a hand		
	When I click on the bet button
	Then I should be told to "You will need to cash in to place a bet."	

Scenario: Finish a game start a new one
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Spades	 | Ace	    |
	  | Diamonds | Eight    |
	  | Clubs	 | Ten		|	  	      
	  | Hearts	 | Two		|      
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button
	Then the player should win the game
	When I click the start new game button
	Then I should see the bet button