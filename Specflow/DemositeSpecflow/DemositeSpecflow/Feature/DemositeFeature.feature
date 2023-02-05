Feature: DemositeFeature
	Login user into demosite web page

@mytag
Scenario: Login User 
	Given I have navigated to Demosite
	And I have entered username 
	And I have entered password 
	When I press login button
	Then I should be navigated to index page
	And I have entered inital 
	And I have entered first name 
	And I have entered middle name
	When I choose female button
	When I press save
	Then I should stay on index page