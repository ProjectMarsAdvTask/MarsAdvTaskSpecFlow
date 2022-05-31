Feature: SearchSkill

@SearchSkillCategory
Scenario: 1. Search Skill Category
	Given I login to the Trade Skills portal for Search Skill successfully
	When I navigate on the Search icon
	And Clicks on the search button
	Then Select the Category & see the record of category

@SearchSkillSubCategory
Scenario: 2. Search Skill Sub-Category
	Given I login to the Trade Skills portal for Search Skill successfully
	When I navigate on the Search icon
	And Clicks on the search button
	Then Select the subcategory & see the record of Sub Category