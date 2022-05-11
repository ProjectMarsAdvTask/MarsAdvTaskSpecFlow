using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsAdvTaskSpecFlow.Pages.ProfilePage
{
    class ProfileSkill
    {
        private IWebDriver testDriver;
        private IWebElement notification => testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement addSkill => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement skillsTextBox => testDriver.FindElement(By.Name("name"));
        private SelectElement levelDDList => new SelectElement(testDriver.FindElement(By.Name("level")));
        private IWebElement addBtn => testDriver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement editSkill => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
        private IWebElement updateSkillBtn => testDriver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement deleteSkill => testDriver.FindElement(By.XPath("//i[@class='remove icon']"));

        public void AddNewSkillsBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Add new" button of skills
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div", 4);
            addSkill.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            return notification.Text;
        }

        public void AddSkills(IWebDriver testDriver, string Skill, string Level)
        {
            this.testDriver = testDriver;

            // Identify the skills textbox enter valid skills
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            skillsTextBox.Click();
            //skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

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
            // Click on edit pen icon of the skills
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]", 4);
            editSkill.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditLSkills(IWebDriver testDriver, string Skill, string Level)
        {
            this.testDriver = testDriver;

            // Identify the skills textbox enter valid skills
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "name", 2);
            skillsTextBox.Click();
            skillsTextBox.Clear();
            skillsTextBox.SendKeys(Skill);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "level", 2);
            levelDDList.SelectByValue(Level);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            updateSkillBtn.Click();
        }

        public void DeleteNewLanguageBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Delete" button of skills
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//i[@class='remove icon']", 4);
            deleteSkill.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
