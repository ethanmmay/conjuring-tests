Feature: BasementPossesion

Go to Basement while Possessed, Scroll Down and Click on Piano Image, then Click Ok on Alert

@testBasement
Scenario: Test Basement Page while Possessed
	Given I am on conjuring site
	When I click possession
	When I click Basement
	When I scroll down
	When I click on the piano
	Then the piano alert appears
