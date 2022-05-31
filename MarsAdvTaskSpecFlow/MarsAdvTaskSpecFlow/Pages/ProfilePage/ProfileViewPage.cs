using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;

namespace MarsAdvTaskSpecFlow.Pages
{
    class ProfileViewPage
    {
        private IWebDriver testDriver;
        private IWebElement NavigateBtn => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/a"));
        private IWebElement imgIconBtn => testDriver.FindElement(By.XPath("//*[@id='home']/div/section[1]/div/div[2]/div/div[2]/div[2]/a/h3"));
        private IWebElement actualUser => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

        public void GoToMainPage(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/div[1]/a", 2);
            NavigateBtn.Click();
        }

        public void NavigateToImgIcon(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='home']/div/section[1]/div/div[2]/div/div[2]/div[2]/a/h3", 2);
            imgIconBtn.Click();
        }

        public string ValidateUser(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Navigate to the Trade Skills portal
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 3);
            return actualUser.Text;
        }
    }
}
