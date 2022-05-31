using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsAdvTaskSpecFlow.Pages.ProfilePage
{
    class ProfileLanguage
    {
        private IWebDriver testDriver;
        private IWebElement Notification => testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement addLanguageBtn => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement languageTextBox => testDriver.FindElement(By.Name("name"));
        private SelectElement levelDDList => new SelectElement(testDriver.FindElement(By.Name("level")));
        private IWebElement addBtn => testDriver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement languagePenIcon => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private IWebElement updateBtn => testDriver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement deleteLanguageBtn => testDriver.FindElement(By.XPath("//i[@class='remove icon']"));

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 3);
            return Notification.Text;
        }

        public void AddNewLanguageBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Add new" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 4);
            addLanguageBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void AddLanguage(IWebDriver testDriver, string Language, string Level)
        {
            this.testDriver = testDriver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            languageTextBox.Click();
            //languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            addBtn.Click();
        }

        public void EditNewLanguageBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 4);
            languagePenIcon.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditLanguage(IWebDriver testDriver, string Language, string Level)
        {
            this.testDriver = testDriver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            levelDDList.SelectByValue(Level);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            updateBtn.Click();
        }

        public void DeleteNewLanguageBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//i[@class='remove icon']", 4);
            deleteLanguageBtn.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}