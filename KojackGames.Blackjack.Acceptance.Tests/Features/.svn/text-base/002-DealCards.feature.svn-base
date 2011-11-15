Feature: Deal Cards
	In order to start a game of black jack
	As a player
	I should be dealt two cards

Scenario: Deal
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Spades	 | Ten	    |
	  | Diamonds | Eight    |
	  | Clubs	 | Six		|    
	  | Hearts	 | Two		|      	  	  
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button
	Then my hand should show the following cards:
	  | card				|
      | Ten of Spades		|
      | Six of Clubs		|
	And the dealers hand should show the following cards:
	  | card				| 
      | Eight of Diamonds   |
	  | hidden				|
