Feature: DataTablePract

data table practice

@withHeading
Scenario: Data table with heading
	Given We have students info
		| Name   | RollNo | Age |
		| Suraj  | 413    | 22  |
		| Ankesh | 432    | 24  |
		| Radha  | 344    | 34  |
	
@withKeyValue
Scenario: Data table as Key-value
	Given we have Employee info
	| Name   | Ankesh |
	| RollNo | 432    |
	| Age    | 34     |

	
