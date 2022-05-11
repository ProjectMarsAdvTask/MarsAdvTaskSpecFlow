using MarsAdvTaskSpecFlow.Pages;
using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition
{
    [Binding]
    public class NotificationSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Login Page object initialization and definition
        Notification notificationObj = new Notification();

        [Given(@"I login to the Trade Skills portal for Notification Page successfully")]
        public void GivenILoginToTheTradeSkillsPortalForNotificationPageSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }
        
        [When(@"I click on the notification button")]
        public void WhenIClickOnTheNotificationButton()
        {
            notificationObj.NotifyDashBoardPage(testDriver);
        }

        [Then(@"The Notification should be displayed")]
        public void ThenTheNotificationShouldBeDisplayed()
        {
            string validNotification = notificationObj.DashBoardPage1(testDriver);

            // Assertion that notification record has been displayed.
            Assert.AreEqual(validNotification, "Notifications", "Actual notifications and expected notifications don't match");
        }

        [When(@"the user Clicks on the Load More button")]
        public void WhenTheUserClicksOnTheLoadMoreButton()
        {
            notificationObj.ValidateLoadMore(testDriver);
        }

        [Then(@"The Load more button should be displayed")]
        public void ThenTheLoadmoreButtonShouldBeDisplayed()
        {
            string validNotification = notificationObj.DashBoardPage1(testDriver);

            // Assertion that notification record has been displayed.
            Assert.AreEqual(validNotification, "Notifications", "Actual notifications and expected notifications don't match");
        }

        [When(@"the user Clicks on the Show Less button")]
        public void WhenTheUserClicksOnTheShowLessButton()
        {
            notificationObj.ValidateShowLess(testDriver);
        }

        [Then(@"The Show Less button should be not displayed")]
        public void ThenTheShowLessButtonShouldBeNotDisplayed()
        {
            string validNotification = notificationObj.DashBoardPage2(testDriver);

            // Assertion that notification record has been displayed.
            Assert.AreEqual(validNotification, "Notifications", "Actual notifications and expected notifications don't match");
        }
    }
}
