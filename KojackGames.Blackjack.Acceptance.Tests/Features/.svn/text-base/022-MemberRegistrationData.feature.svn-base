Feature: Member Registration Data
	In order to see how succesful the site is
	As a Director
	I should be able to obtain the data on the
	total number of registered users

Scenario: Log customers registering
	Given I have registered these people:
	| Email					 | Name		| Password	|
	| Scott@elbandit.co.uk	 | Scott    | Cheese@123|	
	| Jack@Gameble.com		 | Jack     | B@rry123  |	
	| MJ@dancer.org			 | Mike     | Chemic@l  |	
	When I check the regisration logs
	Then I should find "3" "Registration" entries in the logs	
