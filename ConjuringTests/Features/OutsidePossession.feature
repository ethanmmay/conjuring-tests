Feature: OutsidePossession

Go to Outside while Possessed, Click on 20 Crows

@testOutside
Scenario: Test Outside Page while Possessed
	Given I am on conjuring site going towards Outside
	When I click possession for going Outside
	When I click Outside
	When I click 20 crows
	Then the crows possessed is 20
