using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsAdvTaskSpecFlow.SpecFlow.StepDefinition.ProfilePage
{
    class ProfileEducation
    {
        private IWebDriver testDriver;

        private IWebElement addEducation => testDriver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//thead/tr/th[6]/div"));
        private IWebElement notification => testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        private IWebElement UniversityNameTextBox => testDriver.FindElement(By.Name("instituteName"));
        private SelectElement countryLvlDDList => new SelectElement(testDriver.FindElement(By.Name("country")));
        private SelectElement titleLvlDDList => new SelectElement(testDriver.FindElement(By.Name("title")));
        private IWebElement degreeTextBox => testDriver.FindElement(By.Name("degree"));
        private SelectElement yearLvlDDList => new SelectElement(testDriver.FindElement(By.Name("yearOfGraduation")));
        private IWebElement addEducationBtn => testDriver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement updateEducation => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
        private IWebElement updateEducationBtn => testDriver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement deleteEducation => testDriver.FindElement(By.XPath("//i[@class='remove icon']"));

        public void AddNewEducationBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ui bottom attached tab segment tooltip-target active']//thead/tr/th[6]/div", 4);
            addEducation.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver testDriver)
        {
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//div[@class='ns-box-inner']", 4);
            return notification.Text;
        }

        public void AddEducation(IWebDriver testDriver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            UniversityNameTextBox.Click();
            //UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            countryLvlDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            titleLvlDDList.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "degree", 2);
            degreeTextBox.Click();
            //degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            yearLvlDDList.SelectByValue(GraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Add']", 5);
            addEducationBtn.Click();
        }

        public void EditEducationBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 4);
            updateEducation.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditEducation(IWebDriver testDriver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.testDriver = testDriver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "instituteName", 2);
            UniversityNameTextBox.Click();
            UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "country", 2);
            countryLvlDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
            titleLvlDDList.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "degree", 2);
            degreeTextBox.Click();
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "yearOfGraduation", 2);
            yearLvlDDList.SelectByValue(GraduationYear);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//input[@value='Update']", 5);
            updateEducationBtn.Click();
        }

        public void DeleteEducationBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//i[@class='remove icon']", 4);
            deleteEducation.Click();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
