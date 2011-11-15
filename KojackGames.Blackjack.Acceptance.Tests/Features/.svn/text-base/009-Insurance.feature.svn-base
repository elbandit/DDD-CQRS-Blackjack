Feature: Insurance
	In order to increases my chances of making money
	As a player 
	I should be offered an insurance bet

Scenario: Offer insurance bet
	Given that I have logged in with an account with the following details
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"			
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ace		|  
	  | Hearts	 | Two		|    
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	     
	Then I should be given the option for insurance

Scenario: Offer insurance bet only on visible ace
	Given that I have logged in with an account with the following details
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"			
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Two		|    
	  | Hearts	 | Three	|
	  | Hearts	 | Ace		|    	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	     
	Then I should not be given the option for insurance
	
Scenario: Take offer of insurance 
	Given that I have logged in with an account with the following details
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "100" dollars in my pot		
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ace		|  
	  | Hearts	 | Two		|    
	  | Hearts	 | Three	|  	 
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	     
	Then I should be given the option for insurance
	When I click on take insurance
	Then my pot should show "$95.00" dollars

Scenario: Take offer of insurance with dealer not getting blackjack and player losing
	Given that I have logged in with an account with the following details
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "100" dollars in my pot		
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ace		|  
	  | Hearts	 | Two		|    
	  | Hearts	 | Two		|  	 
	  | Hearts	 | Seven	|  	
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	     	
	When I click on take insurance
	Then my pot should show "$95.00" dollars
	When I stick
	Then my pot should show "$95.00" dollars

Scenario: Take offer of insurance with dealer getting blackjack and player losing
	Given that I have logged in with an account with the following details
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	And I have started a new game and bet "10"	
	And I have "100" dollars in my pot		
	And the deck contains the following cards:
	  | Suit	 | Value	|
	  | Diamonds | Eight    |
	  | Hearts	 | Ace		|  
	  | Hearts	 | Two		|    
	  | Hearts	 | Jack		|  	 	  	
	And I have navigated to the game play screen to play a hand	
	When I click on the deal button	     	
	When I click on take insurance
	Then my pot should show "$95.00" dollars
	When I stick
	Then my pot should show "$110.00" dollars