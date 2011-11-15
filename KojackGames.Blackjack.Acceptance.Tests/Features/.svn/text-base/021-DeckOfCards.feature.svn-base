Feature: Deck Of Cards
	In order to play a game of Blackjack
	As a dealer
	I should deal from a pack of cards

Scenario: Take a card from the deck
	Given I have a new deck of 52 cards
	When I take "1" cards
	Then I should have 51 cards left in the deck

Scenario: Take cards from an ordered deck
	Given I have a new deck of 52 cards
	And I have taken the first card
	And that the card is a "Ace" of "Clubs"	
	When I take "3" cards
	Then the last "3" cards taken should be equal to:
		| Suit	| Value	|
		| Clubs	| Two	|
		| Clubs	| Three |
		| Clubs	| Four	|

Scenario: Shuffle the deck
	Given I have a new deck of 52 cards
	And I have taken the first card
	And that the card is a "Ace" of "Clubs"
	And I have shuffled the deck
	When I take "3" cards
	Then the last "3" cards taken should not be equal to:
		| Suit	| Value	|
		| Clubs	| Two	|
		| Clubs	| Three |
		| Clubs	| Four	|	  		

Scenario: check for 52 different cards
	Given I have a new deck of 52 cards
	When I take "52" cards
	Then I should have 52 unique cards
	And an empty deck
