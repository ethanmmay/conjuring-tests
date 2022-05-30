Feature: BedroomUnpossessed

Go to Bedroom while unpossessed, click wardrobe, accept alert, enter weight, repeat

@testBedroomG
Scenario: Test Bedroom while Unpossessed
	Given I am on conjuring site going towards BedroomG
	When I click BedroomG
	When I click on wardrobe and alert
	When I enter low weight and submit
	When I repeat steps and enter high weight
	Then I fall through the house
