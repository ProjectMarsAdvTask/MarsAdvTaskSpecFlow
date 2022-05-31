using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition
{
    [Binding]
    public class LogInPageSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        [Given(@"I logged into the Trade Skills portal successfully")]
        public void GivenILoggedIntoTheTradeSkillsPortalSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();

            loginPageObj.GoToHomePage(testDriver);
        }
        
        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            loginPageObj.ClickSignInBtn(testDriver);
        }

        [When(@"I enter valid '(.*)', '(.*)' records")]
        public void WhenIEnterValidRecords(string Email, string Password)
        {
            loginPageObj.KeyInCredentials1(testDriver, Email, Password);
        }

        [Then(@"I click onto the login button")]
        public void ThenIClickOntoTheLoginButton()
        {
            loginPageObj.ClickLoginBtn(testDriver);
        }
    }
}
