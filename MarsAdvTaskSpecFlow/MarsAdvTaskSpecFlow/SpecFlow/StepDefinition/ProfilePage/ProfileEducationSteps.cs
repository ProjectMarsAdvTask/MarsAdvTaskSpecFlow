using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepFeature.ProfilePage
{
    [Binding]
    public class ProfileEducationSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Language Page object initialization and definition
        ProfileEducation profileEducObj = new ProfileEducation();

        [Given(@"I login to the Trade Skills portal for education successfully")]
        public void GivenILoginToTheTradeSkillsPortalForEducationSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I navigate to the skiils page under Education tab")]
        public void GivenINavigateToTheSkiilsPageUnderEducationTab()
        {
            NaviHomePageObj.EducationPage(testDriver);
        }

        [Given(@"I click on Add New button under Education tab")]
        public void GivenIClickOnAddNewButtonUnderEducationTab()
        {
            profileEducObj.AddNewEducationBtn(testDriver);
        }

        [When(@"I enter the records as '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEnterTheRecordsAsAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            profileEducObj.AddEducation(testDriver, UniversityName, CountryUniversity, Title, Degree, GraduationYear);
        }

        [Then(@"The new row should be added for '(.*)' successfully")]
        public void ThenTheNewRowShouldBeAddedForSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education has been added");
        }

        [Given(@"I click on Edit button of the Education pen icon")]
        public void GivenIClickOnEditButtonOfTheEducationPenIcon()
        {
            profileEducObj.EditEducationBtn(testDriver);
        }

        [When(@"I edit the records in '(.*)', '(.*)', '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenIEditTheRecordsInAndClickOnAddButton(string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            profileEducObj.EditEducation(testDriver, UniversityName, CountryUniversity, Title, Degree, GraduationYear);
        }

        [Then(@"The new row should be updated for '(.*)' successfully")]
        public void ThenTheNewRowShouldBeUpdatedForSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education as been updated");
        }

        [When(@"I click on delete icon under Education tab")]
        public void WhenIClickOnDeleteIconUnderEducationTab()
        {
            profileEducObj.DeleteEducationBtn(testDriver);
        }

        [Then(@"the Education should have the deleted as '(.*)' successfully")]
        public void ThenTheEducationShouldHaveTheDeletedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileEducObj.GetNotification(testDriver), Message, "Education entry successfully removed");
        }
    }
}
