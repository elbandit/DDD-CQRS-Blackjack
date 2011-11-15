Feature: Double Down
	In order to double my stake
	As a player
	I should be offered to double down when my initial 
	two cards add up to 9, 10 or 11 

Scenario: Offer to double
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"	
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Hearts	 | Two		|    
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	Then I should be offered to double my stake

Scenario: Trying to double down without enough money
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "1" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Two		|
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	When I click on the double button
	Then I should be asked "Please cash in to Double Down. You need at least $10.00 dollars."

Scenario: Double Down and lose
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "30" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Nine	    |
	  | Hearts	 | Ten		| 
	  | Hearts	 | Two		|  
	  | Clubs	 | Two		|
	  | Spades	 | Two		|  	 
	  | Hearts	 | Seven	|  	 	  	  
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	When I click on the double button	
	Then my pot should show "$20.00" dollars

Scenario: Double Down and win
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "30" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Two		|
	  | Hearts	 | Three	|  	 
	  | Hearts	 | Two		|  	 
	  | Hearts	 | Jack		| 
	  | Hearts	 | King		| 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	When I click on the double button	
	Then my pot should show "$70.00" dollars