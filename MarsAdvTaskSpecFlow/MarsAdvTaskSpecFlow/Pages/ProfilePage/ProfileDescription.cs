using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace MarsAdvTaskSpecFlow.Pages.ProfilePage
{
    class ProfileDescription
    {
        private IWebDriver testDriver;
        private IWebElement descriptionIcon => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        private IWebElement descriptionTextBox => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement saveButton => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        private IWebElement notification => testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        public void DescriptionPenIcon(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Identify Description icon and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 4);
            descriptionIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void AddDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            // Identify the description textarea enter valid description
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 2);
            Hover.Click(descriptionTextBox).Perform();
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(Description);

            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 5);
            saveButton.Click();
        }

        public string GetDescriptnotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 3);
            return notification.Text;
        }

        public void EditDescription(IWebDriver testDriver, string Description)
        {
            this.testDriver = testDriver;
            Actions Hover = new Actions(testDriver);

            // Identify the description textarea enter valid description
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea", 2);
            Hover.Click(descriptionTextBox).Perform();
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys(Description);

            // Click on "Save" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button", 5);
            saveButton.Click();
        }
    }
}
