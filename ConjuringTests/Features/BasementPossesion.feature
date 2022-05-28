Feature: BasementPossesion

Go to Basement while Possessed

@navBasement
Scenario: Navigate to Basement Page while Possessed
	Given I am on conjuring site
	When I click possesion
	And I click Basement
	Then the result page should have link `https://ethanmmay.github.io/conjuring-site/basement-b`
