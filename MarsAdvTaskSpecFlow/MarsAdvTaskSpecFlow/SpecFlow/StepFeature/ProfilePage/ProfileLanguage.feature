Feature: ProfileLanguage
	As a Seller on Mars
	I would like to add my Profile Details such as Languages.
	So that
	The people seeking for my profile fields which can show in the Languages.

@addlanguage
Scenario: 1. Adding of the Seller Profile Language with records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on the Add New button under Languages tab
	When I enter the data in language and level '<Language>', '<Level>' and click on Add button
	Then The new row should be added as '<Message>' successfully

	Examples:
	| Language | Level  | Message                                   |
	| Japanese | Fluent | Japanese has been added to your languages |

@editlanguage
Scenario: 2. Editing of the Seller Profile Language with records
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on Edit of pen icon under Languages tab
	When edit the data in language and level '<Language>', '<Level>' and click on Add button
	Then The new row should be edited as '<Message>' successfully

	Examples:
	| Language | Level            | Message                                    |
	| English  | Native/Bilingual | English has been updated to your languages |

@deletelanguage
Scenario: 3. Deleting of the Seller Profile Language
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on delete icon under Languages tab
	When The prompt message of the '<Message>' will shown
	Then the Language should have the deleted successfully

	Examples:
	| Message                                      |
	| English has been deleted from your languages |