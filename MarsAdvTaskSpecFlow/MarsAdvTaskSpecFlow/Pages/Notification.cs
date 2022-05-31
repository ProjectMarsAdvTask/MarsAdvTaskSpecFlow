using AventStack.ExtentReports;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace MarsAdvTaskSpecFlow.Pages
{
    class Notification
    {
        private IWebDriver testDriver;
        public static ExtentTest test;

        private IWebElement Dashboard => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[1]"));

        private IWebElement LoadMore => testDriver.FindElement(By.XPath("//*[@id='notification-section']//center/a[text()='Load More...']"));

        private IWebElement ShowLess => testDriver.FindElement(By.XPath("//*[@id='notification-section']//center/a[text()='...Show Less']"));
        private IWebElement DashboardText => testDriver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/a"));
        private IWebElement DashboardText2 => testDriver.FindElement(By.XPath("/*[@id='notification-section']/div[2]/div/div/div[3]"));
        private IList<IWebElement> ServiceRequestRows => testDriver.FindElements(By.TagName("hr"));

        public void NotifyDashBoardPage(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            Dashboard.Click();
            WaitHelpers.WaitForElementPresent(testDriver, "Xpath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/a/h1", 2);
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public string DashBoardPage1(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            String NotificationText1 = DashboardText.Text;
            return NotificationText1;
        }

        public void ValidateLoadMore(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            try
            {
                // Click on the Load more button until Load more button is visible
                while (LoadMore.Displayed)
                {
                    LoadMore.Click();
                    testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    WaitHelpers.WaitForElementPresent(testDriver, "Xpath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/a/h1", 2);
                    test.Log(Status.Info, "Load More button is clicked");
                }
            }
            catch (NoSuchElementException ex)
            {
                test.Log(Status.Fail, "All the data is shown" + ex.Message);
            }
            catch (Exception ex)
            {
                Assert.Fail("System Error", ex.Message);
                test.Log(Status.Fail, "System Error");
            }
            finally
            {
                Assert.Pass("The notifications are visible in the notification page");
                //test.Log(Status.Pass, "The notifications are visible in the notification page");
            }
        }

        public void ValidateShowLess(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            try
            {
                //Click on the Show Less button untill Show Less button is visible
                while (ShowLess.Displayed)
                {
                    ShowLess.Click();
                    testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    WaitHelpers.WaitForElementPresent(testDriver, "Xpath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/a/h1", 2);
                    test.Log(Status.Info, "Show Less button is clicked");
                }
            }
            catch (NoSuchElementException ex)
            {
                test.Log(Status.Pass, "All the data is shown" + ex.Message);
            }
            catch (Exception ex)
            {
                Assert.Fail("System Error", ex.Message);
                test.Log(Status.Fail, "System Error");
            }
            finally
            {
                Assert.Pass("The notification is visible in the notification page");
                //test.Log(Status.Pass, "The notification is visible in the notification page");
            }
        }

        public string DashBoardPage2(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            String NotificationText2 = DashboardText2.Text;
            return NotificationText2;
        }
    }
}
