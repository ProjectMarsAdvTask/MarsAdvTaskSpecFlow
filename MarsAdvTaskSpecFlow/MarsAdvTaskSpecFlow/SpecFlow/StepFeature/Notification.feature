Feature: Notification
	The features of notification tab in the Dashboard page

@MainNotification
Scenario: 1. Check if user is able to click on "Notification"
	Given I login to the Trade Skills portal for Notification Page successfully
	When I click on the notification button
	Then The Notification should be displayed

@LoadMoreNotification
Scenario: 2. Check if user is able to click on "Load more"
	Given I login to the Trade Skills portal for Notification Page successfully
	When I click on the notification button
	When the user Clicks on the Load More button
	Then The Load more button should be displayed	

@ShowLessNotification
Scenario: 3. Check if user is able to click on "Show Less"
	Given I login to the Trade Skills portal for Notification Page successfully
	When I click on the notification button
	And the user Clicks on the Load More button
	When the user Clicks on the Show Less button
	Then The Show Less button should be not displayed