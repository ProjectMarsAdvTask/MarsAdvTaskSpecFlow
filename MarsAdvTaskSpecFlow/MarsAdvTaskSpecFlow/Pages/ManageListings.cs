using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsAdvTaskSpecFlow.Pages
{
    class ManageListings
    {
        private IWebDriver testDriver;

        // Defining all the Web Element                                  
        private IWebElement category => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[2]"));
        private IWebElement title => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        private IWebElement description => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]"));
        private IWebElement serviceType => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]"));
        private IWebElement skillTrade => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[6]/i"));
        private IWebElement credit => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[6]/i"));
        private IList<IWebElement> active => testDriver.FindElements(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input"));
        private IWebElement searchText => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[1]/div[1]/input"));
        private IWebElement manageListingNavigation => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[3]"));
        private IWebElement editManageListBtn => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
        private IWebElement deleteManageListBtn => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
        private IWebElement deleteManageListBtn1 => testDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        private IWebElement deleteManageListBtn2 => testDriver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[1]"));
        private IWebElement viewBtn => testDriver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]"));
        private IWebElement bodyContent => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]"));
        private IWebElement category1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]"));
        private IWebElement subCategory1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
        private IWebElement serviceType1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[3]/div/div[2]"));
        private IWebElement startDate1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[1]/div/div[2]"));
        private IWebElement endDate1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[2]/div/div[2]"));
        private IWebElement locationType1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[3]/div/div[3]/div/div[2]"));
        private IWebElement skillTrade1 => testDriver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[4]/div[2]/div/div/div[2]/span"));

        public void EditManageListings(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            editManageListBtn.Click();
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "title", 2);
        }

        public void NavigateManageListings(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            manageListingNavigation.Click();
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 2);
        }

        public void AddManageListingsActive(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // By calling Excel library to retrive the records
            var expectedCategory = "Programming & Tech";
            var expectedTitle = "Automation Tester";
            var expectedDescription = "Creating test cases and automate test cases.";
            var expectedService = "Hourly";

            // Wait implementation for the table to get displayed
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input", 2);

            // By creating variables for all the records on Manage listing page
            var actualCategory = category.Text;
            var actualTitle = title.Text;
            var actualServiceType = serviceType.Text;
            var actualDescription = description.Text;

            Assert.Multiple(() =>
            {
                // Assertion to validate all the records
                Assert.AreEqual(actualCategory, expectedCategory, "Actual Category and expected category don't match");
                Assert.AreEqual(actualTitle, expectedTitle, "Actual Title and expected title don't match");
                Assert.AreEqual(actualDescription, expectedDescription, "Actual Description and expected description don't match");
                Assert.AreEqual(actualServiceType, expectedService, "Actual Service Type and expected service type don't match");
                Assert.True(active.ElementAt(0).Selected);
            });
        }

        public void EditManageListingsHidden(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // By calling Excel library to retrive the records
            var expectedCategory = "Business";
            var expectedTitle = "Software Test Engineer";
            var expectedDescription = "Manual and Automation Testing";
            var expectedService = "One-off";

            // Wait implementation for the table to get displayed
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input", 2);

            // By creating variables for all the records on Manage listing page
            var actualCategory = category.Text;
            var actualTitle = title.Text;
            var actualServiceType = serviceType.Text;
            var actualDescription = description.Text;

            Assert.Multiple(() =>
            {
                // Assertion to validate all the records
                Assert.AreEqual(actualCategory, expectedCategory, "Actual Category and expected category don't match");
                Assert.AreEqual(actualTitle, expectedTitle, "Actual Title and expected title don't match");
                Assert.AreEqual(actualDescription, expectedDescription, "Actual Description and expected description don't match");
                Assert.AreEqual(actualServiceType, expectedService, "Actual Service Type and expected service type don't match");
                Assert.False(active.ElementAt(0).Selected);
            });
        }

        public void ViewManageListingsActive1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            viewBtn.Click();
        }

        public void ViewManageListingsActive2(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            bodyContent.Click();
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]", 2);
            // By calling Excel library to retrive the records
            var expectedCategory = "Programming & Tech";
            var expectedSubCategory = "QA";
            var expectedService = "Hourly";
            var expectedStartDate = "15122022";
            var expectedEndDate = "15122023";
            var expectedLocationType = "Online";
            var expectedSkillTrade = "Selenium";

            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]", 2);

            // By creating variables for all the records on Manage listing page
            var actualCategory = category1.Text;
            var actualSubCategory = subCategory1.Text;
            var actualServiceType = serviceType1.Text;
            var SDate = startDate1.Text;
            String ActualStartDate = String.Join("", SDate.Split('-').Reverse());
            var EDate = endDate1.Text;
            String ActualEndDate = String.Join("", EDate.Split('-').Reverse());
            var ActualLocationType = locationType1.Text;
            var ActualSkillTrade = skillTrade1.Text;

            Assert.Multiple(() =>
            {
                // Assertion to validate all the records
                Assert.AreNotEqual(actualCategory, expectedCategory, "Actual Category and expected category match");
                Assert.AreEqual(actualSubCategory, expectedSubCategory, "Actual SubCategory and expected subcategory don't match");
                Assert.AreEqual(actualServiceType, expectedService, "Actual Service Type and expected service type don't match");
                Assert.AreEqual(ActualStartDate, expectedStartDate, "Actual Start Date and expected start date don't match");
                Assert.AreEqual(ActualEndDate, expectedEndDate, "Actual End Date and expected end Date don't match");
                Assert.AreEqual(ActualLocationType, expectedLocationType, "Actual Location Type and expected location type don't match");
                Assert.AreEqual(ActualSkillTrade, expectedSkillTrade, "Actual Skill Trade and expected skill trade type don't match");
            });

            // Back to the Manage listing Page
            testDriver.Navigate().Back();
        }

        public void DeleteManageListingBtn1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            deleteManageListBtn.Click();
            // Wait Implementation for delete the service textbox to be visible
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "/html/body/div[2]/div/div[3]/button[2]", 2);
            deleteManageListBtn1.Click();
        }

        public void DeleteManageListingBtn2(IWebDriver testDriver)
        {
            // Wait Implementation for delete the service textbox to be visible
            WaitHelpers.WaitForElementVisible(testDriver, "XPath", "//div[@class='ns-box-inner']", 3);

            // Retrive the text from the pop up message
            String message = testDriver.FindElement(By.XPath("//div[@class='ns-box-inner']")).Text;
            String deletePopUpMsg = $"{title.Text} has been deleted";

            // To Check with the Pop up message for delete
            Assert.That(message, Is.EqualTo(deletePopUpMsg));
        }

        public void WithoutDelManageListBtn1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            deleteManageListBtn.Click();
        }

        public void WithoutDelManageListBtn2(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Wait Implementation for delete the service textbox to be visible
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "/html/body/div[2]/div/div[3]/button[1]", 2);
            deleteManageListBtn2.Click();
        }
    }
}
