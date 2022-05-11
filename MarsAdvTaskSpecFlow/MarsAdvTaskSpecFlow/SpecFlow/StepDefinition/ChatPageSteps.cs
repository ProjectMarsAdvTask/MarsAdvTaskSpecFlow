using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepFeature
{
    [Binding]
    public class ChatPageSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Chat Page object initialization and definition
        ChatPage chatPageObj = new ChatPage();

        [Given(@"I login to the Trade Skills portal for Chat Page successfully")]
        public void GivenILoginToTheTradeSkillsPortalForChatPageSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [When(@"I click on the Chat navigation button")]
        public void WhenIClickOnTheChatNavigationButton()
        {
            chatPageObj.NaviChatHistoryBtn(testDriver);
        }

        [Then(@"the user should be able to see Chat History and dashboard")]
        public void ThenTheUserShouldBeAbleToSeeChatHistoryAndDashboard()
        {
            chatPageObj.ChatHistoryList(testDriver);
        }
    }
}
