Feature: Split
	In order to increase my chance of winning 
	As a player
	I should be offered to split my hand if initial two cards make a pair

Scenario: Offer to split
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"	
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Eight    |
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	Then I should be offered to split my hand

Scenario: Trying to split without enough money
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "1" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Eight    |
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	When I click on the split button
	Then I should be asked "Please cash in to Split. You need at least $10.00 dollars."

Scenario: Split hand
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"	
	And I have "30" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Eight    |
	  | Hearts	 | Three	|  	 
	  | Hearts	 | Four		| 
	  | Hearts	 | Seven	| 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	Then I should be offered to split my hand
	When I click on the split button	
	Then hand "A" should show the following cards:
	  | card				|
      | Eight of Diamonds	|
      | Four of Hearts		|
	And hand "B" should show the following cards:
	  | card				|
      | Eight of Clubs		|
      | Seven of Hearts		|
	And my pot should show "$25.00" dollars


Scenario: Split hand and complete game
	Given that I have logged in with an account with the following details
	  | Email					 | Name		| Password	|
	  | Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "5"	
	And I have "30" dollars in my pot
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ten		|  
	  | Clubs	 | Eight    |
	  | Hearts	 | Three	|  	 
	  | Hearts	 | Four		| 
	  | Hearts	 | Seven	| 
	  | Clubs	 | Four		| 
	  | Spades	 | Four		|
	  | Spades	 | Jack		|
	  | Spades	 | Queen	|
	  | Clubs	 | Queen	|
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	
	Then I should be offered to split my hand
	When I click on the split button	
	Then hand "A" should show the following cards:
	  | card				|
      | Eight of Diamonds	|
      | Four of Hearts		|
	And hand "B" should show the following cards:
	  | card				|
      | Eight of Clubs		|
      | Seven of Hearts		|
	When I hit 
	When I stick
	Then hand "A" should show the following cards:
	  | card				|
      | Eight of Diamonds	|
      | Four of Hearts		|
	  | Four of Clubs		|
	When I hit 
	When I stick
	Then hand "B" should show the following cards:
	  | card				|
      | Eight of Clubs		|
      | Seven of Hearts		|
	  | Four of Spades		|
	Then players hand "A" should have won
	Then players hand "B" should have won