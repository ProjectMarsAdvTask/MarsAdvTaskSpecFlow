using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage
{
    class ProfileCertification
    {
        private IWebDriver testDriver;
        private IWebElement notification => testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement addCertification => testDriver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//thead/tr/th[4]/div"));
        private IWebElement addCertificationBtn => testDriver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement updateCertification => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
        private IWebElement updateCertificationBtn => testDriver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement deleteCertification => testDriver.FindElement(By.XPath("//i[@class='remove icon']"));
        private IWebElement certificationTextBox1 => testDriver.FindElement(By.Name("certificationName"));
        private IWebElement certificationTextBox2 => testDriver.FindElement(By.Name("certificationFrom"));
        private SelectElement levelDDList => new SelectElement(testDriver.FindElement(By.Name("certificationYear")));

        public void AddNewCertBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ui bottom attached tab segment tooltip-target active']//thead/tr/th[4]/div", 4);
            addCertification.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            return notification.Text;
        }

        public void AddCertification(IWebDriver testDriver, string Certificate, string From, string Year)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            certificationTextBox1.Click();
            //certificationTextBox1.Clear();
            certificationTextBox1.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            certificationTextBox2.Click();
            //certificationTextBox2.Clear();
            certificationTextBox2.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationYear", 2);
            levelDDList.SelectByValue(Year);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            addCertificationBtn.Click();
        }

        public void EditNewCertBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i", 4);
            updateCertification.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditCertification(IWebDriver testDriver, string Certificate, string From, string Year)
        {
            this.testDriver = testDriver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationName", 2);
            certificationTextBox1.Click();
            certificationTextBox1.Clear();
            certificationTextBox1.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationFrom", 2);
            certificationTextBox2.Click();
            certificationTextBox2.Clear();
            certificationTextBox2.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "certificationYear", 2);
            levelDDList.SelectByValue(Year);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            updateCertificationBtn.Click();
        }

        public void DeleteNewCertBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//i[@class='remove icon']", 4);
            deleteCertification.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
