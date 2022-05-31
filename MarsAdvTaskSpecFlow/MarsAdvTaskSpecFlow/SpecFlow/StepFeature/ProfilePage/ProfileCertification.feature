Feature: ProfileCertification
	As a Seller on Mars
	I would like to add my Profile Details such as Certifications.
	So that
	The people seeking for my profile fields which can show in the Certifications.

@addCertifications2
Scenario: 1. Adding of the Seller Profile Certifications with valid records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on the Add New button under Certifications tab
	When I enter the details in '<Certificate>', '<From>', '<Year>' and click on add button
	Then A new row should be added as in '<Message>' successfully

	Examples:
	| Certificate | From  | Year | Message                                    |
	| CT-MT       | ISTQB | 2019 | CT-MT has been added to your certification |

@editCertifications
Scenario: 2. Editing of the Seller Profile Certifications with records
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	And I click on the Certification pen icon
	When edit the data in '<Certificate>', '<From>', '<Year>' and click on Add button
	Then The new row should be updated as '<Message>' successfully

	Examples:
	| Certificate | From     | Year | Message                                         |
	| CTFL-AuT    | ISTQB-V2 | 2020 | CTFL-AuT has been updated to your certification |

@deleteCertifications
Scenario: 3. Deleting of the Seller Certifications Language
	Given I login to the Trade Skills portal for Certs successfully
	And I navigate to the skiils page under Certifications tab
	When I click on delete icon under Certification tab
	Then the Certification should have the deleted as '<Message>' successfully

	Examples:
	| Message                                           |
	| CTFL-AuT has been deleted from your certification |