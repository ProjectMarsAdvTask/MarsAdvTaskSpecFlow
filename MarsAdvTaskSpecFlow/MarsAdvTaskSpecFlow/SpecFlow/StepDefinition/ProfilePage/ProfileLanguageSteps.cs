using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepFeature.ProfilePage
{
    [Binding]
    public class ProfileLanguageSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Profile Language Page object initialization and definition
        ProfileLanguage profileLanguageObj = new ProfileLanguage();

        [Given(@"I login to the Trade Skills portal in the Profile successfully")]
        public void GivenILoginToTheTradeSkillsPortalInTheProfileSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I click on the Add New button under Languages tab")]
        public void GivenIClickOnTheAddNewButtonUnderLanguagesTab()
        {
            profileLanguageObj.AddNewLanguageBtn(testDriver);
        }

        [When(@"I enter the data in language and level '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInLanguageAndLevelAndClickOnAddButton(string Language, string Level)
        {
            profileLanguageObj.AddLanguage(testDriver, Language, Level);
        }

        [Then(@"The new row should be added as '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "English has been added to your languages");
        }

        [Given(@"I click on Edit of pen icon under Languages tab")]
        public void GivenIClickOnEditOfPenIconUnderLanguagesTab()
        {
            profileLanguageObj.EditNewLanguageBtn(testDriver);
        }

        [When(@"edit the data in language and level '(.*)', '(.*)' and click on Add button")]
        public void WhenEditTheDataInLanguageAndLevelAndClickOnAddButton(string Language, string Level)
        {
            profileLanguageObj.EditLanguage(testDriver, Language, Level);
        }

        [Then(@"The new row should be edited as '(.*)' successfully")]
        public void ThenTheNewRowShouldBeEditedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "English has been updated to your languages");
        }

        [Given(@"I click on delete icon under Languages tab")]
        public void GivenIClickOnDeleteIconUnderLanguagesTab()
        {
            profileLanguageObj.DeleteNewLanguageBtn(testDriver);
        }

        [When(@"The prompt message of the '(.*)' will shown")]
        public void WhenThePromptMessageOfTheWillShown(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileLanguageObj.GetNotification(testDriver), Message, "English has been deleted from your languages");
        }

        [Then(@"the Language should have the deleted successfully")]
        public void ThenTheLanguageShouldHaveTheDeletedSuccessfully()
        {
            string notification = profileLanguageObj.GetNotification(testDriver);

            // Assertion that Description notification has been displayed.
            Assert.AreEqual(notification, "English has been deleted from your languages");
        }
    }
}