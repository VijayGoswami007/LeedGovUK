Feature: Online Form Templates

@mytag
Scenario: 1. Form Template Homepage
	Given I am a user of an online form
	When I navigate to the URL 'https://services-act.leeds.gov.uk/FormTemplate'
	Then I can see the starting page of the form 

@mytag
Scenario: 2. Form Template Start Question
	Given I have navigated to the online form
	And I am on the starting page
	When I click ‘Start now’
	Then I can see first question page of the form 

@QuestionPage
Scenario: 3. Form Template Question Page
	Given I am on the first question page of the form
	When I select nothing
	And click ‘Continue’
	Then I can see an error message 

@MapPage
Scenario: 4. Form Template Map Page
	Given I am on the first question page
	When I select ‘No’
	And click the ‘Continue’ button
	Then I can see the ‘Map’ page 

@MapNextPage
Scenario: 5. Form Template MapNext Page
	Given I am on the Map page
	When I enter the postcode 'LS1 1UR' in the box
	And click ‘Find address’
	Then I can select the address 'LEEDS CITY COUNCIL, CIVIC HALL'
	And I can click Continue