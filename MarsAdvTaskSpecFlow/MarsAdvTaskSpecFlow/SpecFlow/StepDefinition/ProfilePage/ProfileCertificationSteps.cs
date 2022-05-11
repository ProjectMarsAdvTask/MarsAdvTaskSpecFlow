using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage
{
    [Binding]
    public class ProfileCertificationSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Home Page object initialization and definition
        HomePage NaviHomePageObj = new HomePage();

        // Profile Certications Page object initialization and definition
        ProfileCertification profileCertsObj = new ProfileCertification();

        [Given(@"I login to the Trade Skills portal for Certs successfully")]
        public void GivenILoginToTheTradeSkillsPortalForCertsSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [Given(@"I navigate to the skiils page under Certifications tab")]
        public void GivenINavigateToTheSkiilsPageUnderCertificationsTab()
        {
            NaviHomePageObj.CertificationsPage(testDriver);
        }

        [Given(@"I click on the Add New button under Certifications tab")]
        public void GivenIClickOnTheAddNewButtonUnderCertificationsTab()
        {
            profileCertsObj.AddNewCertBtn(testDriver);
        }

        [When(@"I enter the details in '(.*)', '(.*)', '(.*)' and click on add button")]
        public void WhenIEnterTheDetailsInAndClickOnAddButton(string Certificate, string From, string Year)
        {
            profileCertsObj.AddCertification(testDriver, Certificate, From, Year);
        }

        [Then(@"A new row should be added as in '(.*)' successfully")]
        public void ThenANewRowShouldBeAddedAsInSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CT-MT has been added to your certification");
        }

        [Given(@"I click on the Certification pen icon")]
        public void GivenIClickOnTheCertificationPenIcon()
        {
            profileCertsObj.EditNewCertBtn(testDriver);
        }

        [When(@"edit the data in '(.*)', '(.*)', '(.*)' and click on Add button")]
        public void WhenEditTheDataInAndClickOnAddButton(string Certificate, string From, string Year)
        {
            profileCertsObj.EditCertification(testDriver, Certificate, From, Year);
        }

        [Then(@"The new row should be updated as '(.*)' successfully")]
        public void ThenTheNewRowShouldBeUpdatedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been updated to your certification");
        }

        [When(@"I click on delete icon under Certification tab")]
        public void WhenIClickOnDeleteIconUnderCertificationTab()
        {
            profileCertsObj.DeleteNewCertBtn(testDriver);
        }

        [Then(@"the Certification should have the deleted as '(.*)' successfully")]
        public void ThenTheCertificationShouldHaveTheDeletedAsSuccessfully(string Message)
        {
            // Assertion that popup message record has been displayed.
            Assert.AreEqual(profileCertsObj.GetNotification(testDriver), Message, "CTFL-AuT has been deleted from your certification");
        }
    }
}
