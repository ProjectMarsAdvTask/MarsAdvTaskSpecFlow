Feature: ManageListings

@AddShareSkill
Scenario: 1. Adding of the Share Skill on Manage Listing Page
	Given I login to the Trade Skills portal for Share Skill successfully
	And the user clicks on the ShareSkill button for adding
	When the user fills as '<Title>', '<Description>', '<CategoryId>', '<subCategoryId>', '<TagData>', '<StartDate>', '<EndDate>', '<StartTime>', '<EndTime>', '<Skill>' the ShareSkill form
	Then the User should be able to see the skill on the Manage Listing page

	Examples:
	| Title             | Description                                  | CategoryId         | subCategoryId | TagData  | StartDate  | EndDate    | StartTime  | EndTime    | Skill    |
	| Automation Tester | Creating test cases and automate test cases. | Programming & Tech | QA            | Selenium | 15/12/2022 | 15/12/2023 | 9:30:00 AM | 5:00:00 PM | Selenium |
	
@ValidateShareSkill
Scenario: 2. Validate of the Share Skill on Manage Listing Page
	Given I login to the Trade Skills portal for Share Skill successfully
	And the User navigates to the Manage Listing Page
	When the user click on the view button for validation
	Then the User should able to validate the skill on the Manage Listing page

@EditShareSkill
Scenario: 3. Edit of the Shared Skill on Manage Listing Page
	Given I login to the Trade Skills portal for Share Skill successfully
	And the user clicks on the ShareSkill button for editing
	When the User fills the ShareSkill form as '<Title>', '<Description>', '<CategoryId>', '<subCategoryId>', '<TagData>', '<StartDate>', '<EndDate>', '<StartTime>', '<EndTime>', '<CreditAmt>'
	Then the User should be able to see the edited Skill on the Manage Listing page

	Examples:
	| Title                  | Description                   | CategoryId | subCategoryId | TagData    | StartDate  | EndDate    | StartTime   | EndTime    | CreditAmt |
	| Software Test Engineer | Manual and Automation Testing | Business   | Other         | JavaScript | 22/12/2022 | 22/12/2023 | 10:00:00 AM | 5:30:00 PM | 7         |

@NotDeleteShareSkill
Scenario: 4. Not Delete of the Shared Skill on Manage Listing Page
	Given I login to the Trade Skills portal for Share Skill successfully
	And the User navigates to the Manage Listing Page
	When the User clicks the Delete button of a Shared Skill
	Then the User should be able to see the deleted Skill on the Manage Listing page

@DeleteShareSkill
Scenario: 5. Delete of the Shared Skill on Manage Listing Page
	Given I login to the Trade Skills portal for Share Skill successfully
	And the User navigates to the Manage Listing Page
	When the user clicks on the Delete button of a Shared Skill
	Then the User shouldn't be able to see the deleted Skill on the Manage Listing page