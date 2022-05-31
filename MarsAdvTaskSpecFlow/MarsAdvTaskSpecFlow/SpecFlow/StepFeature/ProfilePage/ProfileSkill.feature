Feature: ProfileSkill
	As a Seller on Mars
	I would like to add my Profile Details such as Skills.
	So that
	The people seeking for my profile fields which can show in the Skills.

@addSkills
Scenario: 1. Adding of the Seller Profile Skills with records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on the Add New button under Skills section
	When I enter the records of '<Skill>', '<Level>' and click on Add button
	Then The new row should be added '<Message>' successfully

	Examples:
	| Skill    | Level        | Message                                |
	| Selenium | Intermediate | Selenium has been added to your skills |

@editSkills
Scenario: 2. Editing of the Seller Profile Skills with records
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	And I click on edit pen icon under Skills tab
	When I edit the data in '<Skill>', '<Level>' and click on Add button
	Then The new row should be edited '<Message>' successfully

	Examples:
	| Skill    | Level  | Message                                  |
	| SpecFlow | Expert | SpecFlow has been updated to your skills |

@deleteSkills
Scenario: 3. Deleting of the Seller Profile Skill
	Given I login to the Trade Skills portal in Profile successfully
	And I navigate to the skiils page under Skills tab
	When I click on delete icon under Skills tab
	Then the Skill should have the deleted as '<Message>' successfully

	Examples:
	| Message                   |
	| SpecFlow has been deleted |