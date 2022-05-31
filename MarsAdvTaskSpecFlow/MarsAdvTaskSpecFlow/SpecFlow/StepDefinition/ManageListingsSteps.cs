using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition
{
    [Binding]
    public class ManageListingsSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage homePageObj = new HomePage();

        // Share Skill Page object initialization and definition
        ShareSkill shareSkillObj = new ShareSkill();

        // Manage Listings Page object initialization and definition
        ManageListings manageListsObj = new ManageListings();

        [Given(@"I login to the Trade Skills portal for Share Skill successfully")]
        public void GivenILoginToTheTradeSkillsPortalForShareSkillSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"the user clicks on the ShareSkill button for adding")]
        public void GivenTheUserClicksOnTheShareSkillButtonForAdding()
        {
            homePageObj.ShareSkillBtn(testDriver);
        }

        [When(@"the user fills as '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' the ShareSkill form")]
        public void WhenTheUserFillsAsTheShareSkillForm(string Title, string Description, string CategoryId, string subCategoryId, string TagData, string StartDate, string EndDate, string StartTime, string EndTime, string Skill)
        {
            shareSkillObj.AddTitle(testDriver, Title);
            shareSkillObj.AddDescription(testDriver, Description);
            shareSkillObj.SelectAddCategory(testDriver, CategoryId);
            shareSkillObj.SelectAddSubCategory(testDriver, subCategoryId);
            shareSkillObj.AddEnterTags(testDriver, TagData);
            shareSkillObj.ServiceTypeHourly();
            shareSkillObj.LocationTypeOnline();
            shareSkillObj.AddAvailableDays(testDriver, StartDate, EndDate, StartTime, EndTime);
            shareSkillObj.SkillExchange(testDriver, Skill);
            shareSkillObj.ActiveShareSkill();
            shareSkillObj.SaveShareSkill();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Then(@"the User should be able to see the skill on the Manage Listing page")]
        public void ThenTheUserShouldBeAbleToSeeTheSkillOnTheManageListingPage()
        {
            manageListsObj.AddManageListingsActive(testDriver);
        }

        [Given(@"the User navigates to the Manage Listing Page")]
        public void GivenTheUserNavigatesToTheManageListingPage()
        {
            manageListsObj.NavigateManageListings(testDriver);
        }

        [When(@"the user click on the view button for validation")]
        public void WhenTheUserClickOnTheViewButtonForValidation()
        {
            manageListsObj.ViewManageListingsActive1(testDriver);
        }

        [Then(@"the User should able to validate the skill on the Manage Listing page")]
        public void ThenTheUserShouldAbleToValidateTheSkillOnTheManageListingPage()
        {
            manageListsObj.ViewManageListingsActive2(testDriver);
        }

        [Given(@"the user clicks on the ShareSkill button for editing")]
        public void GivenTheUserClicksOnTheShareSkillButtonForEditing()
        {
            manageListsObj.NavigateManageListings(testDriver);
            manageListsObj.EditManageListings(testDriver);
        }

        [When(@"the User fills the ShareSkill form as '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)', '(.*)'")]
        public void WhenTheUserFillsTheShareSkillFormAs(string Title, string Description, string CategoryId, string subCategoryId, string TagData, string StartDate, string EndDate, string StartTime, string EndTime, string CreditAmt)
        {
            shareSkillObj.EditTitle(testDriver, Title);
            shareSkillObj.EditDescription(testDriver, Description);
            shareSkillObj.SelectEditCategory(testDriver, CategoryId);
            shareSkillObj.SelectEditSubCategory(testDriver, subCategoryId);
            shareSkillObj.EditTags(testDriver, TagData);
            shareSkillObj.ServiceTypeOne_off();
            shareSkillObj.LocationTypeOnsite();
            shareSkillObj.EditAvailableDays(testDriver, StartDate, EndDate, StartTime, EndTime);
            shareSkillObj.EditCreditExchange(testDriver, CreditAmt);
            shareSkillObj.HiddenShareSkill();
            shareSkillObj.SaveShareSkill();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Then(@"the User should be able to see the edited Skill on the Manage Listing page")]
        public void ThenTheUserShouldBeAbleToSeeTheEditedSkillOnTheManageListingPage()
        {
            manageListsObj.EditManageListingsHidden(testDriver);
        }

        [When(@"the User clicks the Delete button of a Shared Skill")]
        public void WhenTheUserClicksTheDeleteButtonOfASharedSkill()
        {
            manageListsObj.WithoutDelManageListBtn1(testDriver);
        }

        [Then(@"the User should be able to see the deleted Skill on the Manage Listing page")]
        public void ThenTheUserShouldBeAbleToSeeTheDeletedSkillOnTheManageListingPage()
        {
            manageListsObj.WithoutDelManageListBtn2(testDriver);
        }

        [When(@"the user clicks on the Delete button of a Shared Skill")]
        public void WhenTheUserClicksOnTheDeleteButtonOfASharedSkill()
        {
            manageListsObj.DeleteManageListingBtn1(testDriver);
        }

        [Then(@"the User shouldn't be able to see the deleted Skill on the Manage Listing page")]
        public void ThenTheUserShouldnTBeAbleToSeeTheDeletedSkillOnTheManageListingPage()
        {
            manageListsObj.DeleteManageListingBtn2(testDriver);
        }
    }
}
