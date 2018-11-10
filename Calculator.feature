Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator to add
	And I have also entered 70 into the calculator to add
	When I press add
	Then the result should be 120 on the screen when adding

Scenario: Substract two numbers
	Given I have entered 70 into the calculator to be substracted
	And I have also entered 20 into the calculator to substract
	When I press substract
	Then the result should be 50 on the screen when substracting

Scenario: Multiply two numbers
	Given I have entered 70 into the calculator to multiply
	And I have also entered 25 into the calculator to multiply
	When I press multiply
	Then the result should be 1750 on the screen when multiplying

Scenario: Divide two numbers
	Given I have entered 960 into the calculator to be divided
	And I have also entered 20 into the calculator to divide
	When I press divide
	Then the result should be 48 on the screen when dividing