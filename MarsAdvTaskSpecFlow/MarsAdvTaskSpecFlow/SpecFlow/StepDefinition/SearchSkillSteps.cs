using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition
{
    [Binding]
    public class SearchSkillSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage homePageObj = new HomePage();

        // Search Skill object initialization and definition
        SearchSkill searchSkillObj = new SearchSkill();

        [Given(@"I login to the Trade Skills portal for Search Skill successfully")]
        public void GivenILoginToTheTradeSkillsPortalForSearchSkillSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [When(@"I navigate on the Search icon")]
        public void WhenINavigateOnTheSearchIcon()
        {
            homePageObj.NavigateMarsLogo(testDriver);
        }

        [When(@"Clicks on the search button")]
        public void WhenClicksOnTheSearchButton()
        {
            homePageObj.SearchBtn(testDriver);
        }

        [Then(@"Select the Category & see the record of category")]
        public void ThenSelectTheCategoryAsSeeTheRecordOfCategory()
        {
            searchSkillObj.SearchSkillCategory(testDriver);
        }

        [Then(@"Select the subcategory & see the record of Sub Category")]
        public void ThenSelectTheSubcategoryAsSeeTheRecordOfSubCategory()
        {
            searchSkillObj.SearchSkillSubCategory(testDriver);
        }
    }
}
