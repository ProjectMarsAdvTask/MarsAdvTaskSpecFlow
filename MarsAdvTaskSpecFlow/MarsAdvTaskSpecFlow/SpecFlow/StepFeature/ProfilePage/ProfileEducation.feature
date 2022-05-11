Feature: ProfileEducation
	As a Seller on Mars
	I would like to add my Profile Details such as Education.
	So that
	The people seeking for my profile fields which can show in the Education.

@addEducation
Scenario: 1. Adding of the Seller Profile Education with records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on Add New button under Education tab
	When I enter the records as '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The new row should be added for '<Message>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title | Degree           | GraduationYear | Message                  |
	| NUS            | Singapore         | B.Sc  | Software-Testing | 2021           | Education has been added |

@editEducation
Scenario: 2. Editing of the Seller Profile Education with records
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	And I click on Edit button of the Education pen icon
	When I edit the records in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The new row should be updated for '<Message>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title  | Degree           | GraduationYear | Message                   |
	| SMU            | Singapore         | B.Tech | Software Testing | 2022           | Education as been updated |

@deleteEducation
Scenario: 3. Deleting of the Seller Profile Education
	Given I login to the Trade Skills portal for education successfully
	And I navigate to the skiils page under Education tab
	When I click on delete icon under Education tab
	Then the Education should have the deleted as '<Message>' successfully

	Examples:
	| Message                              |
	| Education entry successfully removed |