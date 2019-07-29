Feature: Playground
	In order to work with People section
	As a user
	I want to be able to create, edit and delete a person

Background: 
	Given user is logged in
	And playground section is opened

@Playground
Scenario: Person can be created
	Given user clicks on People tab
		And clicks on 'CREATE PERSON' button
		And enters any value in the Full Name field
		And selects any option under technlogies dropdown menu
		And selects any option under seniority dropdown menu
	When user clicks on Submit button
	Then person is created

@Playground
Scenario: Person's first and last name can switch places
	Given user clicks on People tab
		And opens first person from the list
		And switch first and last name's places
	When user clicks on Submit button to save changes
	Then updated full name with switched first and last name's places is displayed in the people list

@Playground
Scenario: People can be removed from the list
	Given user clicks on People tab
		And opens first person from the list
	When user clicks on Delete icon
		And confirms deletion by clicking on Delete button on the pop-up
	Then user is removed from the system and people list is empty with 'No people added yet. Click on CREATE PERSON to add some.' message

@Playground
Scenario: Technology can be created
	Given user clicks on Technology tab
		And clicks on 'CREATE TECHNOLOGY' button
		And enters any value in the Technology Title field
	When user clicks on Submit button
	Then technology is created

@Playground
Scenario: Seniority can be created
	Given user clicks on Seniority tab
		And clicks on 'CREATE SENIORITY' button
		And enters any value in the Seniority Title field
	When user clicks on Submit button
	Then seniority is created