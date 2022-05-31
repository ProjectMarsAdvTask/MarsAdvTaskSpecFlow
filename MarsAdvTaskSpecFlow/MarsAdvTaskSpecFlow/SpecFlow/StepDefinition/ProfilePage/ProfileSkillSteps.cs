using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage
{
    [Binding]
    public class ProfileSkillSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Language Page object initialization and definition
        ProfileSkill profileSkillsObj = new ProfileSkill();

        [Given(@"I login to the Trade Skills portal in Profile successfully")]
        public void GivenILoginToTheTradeSkillsPortalInProfileSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I navigate to the skiils page under Skills tab")]
        public void GivenINavigateToTheSkiilsPageUnderSkillsTab()
        {
            NaviHomePageObj.SkillsPage(testDriver);
        }

        [Given(@"I click on the Add New button under Skills section")]
        public void GivenIClickOnTheAddNewButtonUnderSkillsSection()
        {
            profileSkillsObj.AddNewSkillsBtn(testDriver);
        }

        [When(@"I enter the records of '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsOfAndClickOnAddButton(string Skill, string Level)
        {
            profileSkillsObj.AddSkills(testDriver, Skill, Level);
        }

        [Then(@"The new row should be added '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "Selenium has been added to your skills");
        }

        [Given(@"I click on edit pen icon under Skills tab")]
        public void GivenIClickOnEditPenIconUnderSkillsTab()
        {
            profileSkillsObj.EditNewLanguageBtn(testDriver);
        }

        [When(@"I edit the data in '(.*)', '(.*)' and click on Add button")]
        public void WhenIEditTheDataInAndClickOnAddButton(string Skill, string Level)
        {
            profileSkillsObj.EditLSkills(testDriver, Skill, Level);
        }

        [Then(@"The new row should be edited '(.*)' successfully")]
        public void ThenTheNewRowShouldBeEditedSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "SpecFlow has been updated to your skills");
        }

        [When(@"I click on delete icon under Skills tab")]
        public void WhenIClickOnDeleteIconUnderSkillsTab()
        {
            profileSkillsObj.DeleteNewLanguageBtn(testDriver);
        }

        [Then(@"the Skill should have the deleted as '(.*)' successfully")]
        public void ThenTheSkillShouldHaveTheDeletedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileSkillsObj.GetNotification(testDriver), Message, "SpecFlow has been deleted");
        }
    }
}
