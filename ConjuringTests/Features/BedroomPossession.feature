Feature: BedroomPossession

Go to Bedroom while Possessed, Adjust slider back and forth 3 times

@testBedroomB
Scenario: Test Bedroom while Possessed
	Given I am on conjuring site going towards BedroomB
	When I click possession for going to BedroomB
	When I click BedroomB
	When I raise and lower slider 3 times
	Then the slider is back at 0
