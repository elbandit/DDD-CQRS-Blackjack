Feature: Paying Out
	In order to make money
	As a Customer
	I should have winnings added to my pot when I win a game

Scenario: Player wins some money
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"
	And I have "10" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Ace	    |
	  | Diamonds | Eight    |
	  | Clubs	 | Ten		|    
	  | Hearts	 | Two		|      	  	  
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button
	Then my pot should show "$35.00" dollars
