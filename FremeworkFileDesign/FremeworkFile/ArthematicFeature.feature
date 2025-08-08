
Feature: ArthematicFeature

Addition of two numebrs

@Addition
Scenario: Adding two number
	Given First numebr is 150
	And Second numebr is 30
	When We perform additon
	Then Resule should be 180

@Sub
Scenario Outline: Subtrating two number
	Given First number is '<FirstNum>'
	And Second number is '<SecNum>'
	When we perform subtraction
	Then Result should be '<FinalAns>'
Examples:
	| FirstNum | SecNum | FinalAns |
	| 40       | 20     | 20       |
	| 100      | 60     | 40       |