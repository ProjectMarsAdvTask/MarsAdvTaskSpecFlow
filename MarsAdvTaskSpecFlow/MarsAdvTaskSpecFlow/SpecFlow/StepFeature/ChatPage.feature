Feature: ChatPage
	Validate Chat and Chat History

@ChatHistory
Scenario: 1. Check if user is able to click and show the Chat History
	Given I login to the Trade Skills portal for Chat Page successfully
	When I click on the Chat navigation button
	Then the user should be able to see Chat History and dashboard