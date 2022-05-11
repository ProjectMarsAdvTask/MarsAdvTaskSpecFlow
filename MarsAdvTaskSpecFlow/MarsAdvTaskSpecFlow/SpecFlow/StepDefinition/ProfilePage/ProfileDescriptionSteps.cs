using MarsAdvTaskSpecFlow.Pages.ProfilePage;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage
{
    [Binding]
    public class ProfileDescriptionSteps : CommonDriver
    {
        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();

        // Login Page object initialization and definition
        ProfileDescription profileDetailsObj = new ProfileDescription();

        [Given(@"I login to Trade Skills portal description successfully")]
        public void GivenILoginToTradeSkillsPortalDescriptionSuccessfully()
        {
            // Open chrome browser
            testDriver = new ChromeDriver();
            loginPageObj.LoginPageSteps(testDriver);
        }

        [Given(@"I click on the description pen icon")]
        public void GivenIClickOnTheDescriptionPenIcon()
        {
            profileDetailsObj.DescriptionPenIcon(testDriver);
        }

        [When(@"I add the '(.*)' and click on Save button")]
        public void WhenIAddTheAndClickOnSaveButton(string Description)
        {
            profileDetailsObj.AddDescription(testDriver, Description);
        }

        [Then(@"the Description should be added as successfully")]
        public void ThenTheDescriptionShouldBeAddedAsSuccessfully()
        {
            string notification = profileDetailsObj.GetDescriptnotification(testDriver);

            // Assertion that Description notification has been displayed.
            Assert.AreEqual(notification, "Description has been saved successfully");
        }

        [When(@"I edit the '(.*)' and click on Save button")]
        public void WhenIEditTheAndClickOnSaveButton(string Description)
        {
            profileDetailsObj.EditDescription(testDriver, Description);
        }

        [Then(@"the Description should be updated as successfully")]
        public void ThenTheDescriptionShouldBeUpdatedAsSuccessfully()
        {
            string notification = profileDetailsObj.GetDescriptnotification(testDriver);

            // Assertion that Description notification has been displayed.
            Assert.AreEqual(notification, "Description has been saved successfully");
        }
    }
}
