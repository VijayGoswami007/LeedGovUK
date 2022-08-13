Feature: Online Form Templates

@mytag
Scenario: Form Template Homepage
	Given I am a user of an online form
	When I navigate to the URL 'https://services-act.leeds.gov.uk/FormTemplate'
	Then I can see the starting page of the form 

@mytag
Scenario: Form Template Start Question
	Given I have navigated to the online form
	And I am on the starting page
	When I click ‘Start now’
	Then I can see first question page of the form 