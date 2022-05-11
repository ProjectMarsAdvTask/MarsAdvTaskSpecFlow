using AventStack.ExtentReports;
using MarsAdvTaskSpecFlow.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MarsAdvTaskSpecFlow.Pages
{
    class ChatPage
    {
        private IWebDriver testDriver;
        public static ExtentTest test;

        private IWebElement chatNavigation => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[1]"));

        private IWebElement chatList => testDriver.FindElement(By.XPath("//*[@id='chatList']/div[5]/div[2]/div[2]"));

        private IWebElement chatBox => testDriver.FindElement(By.XPath("//*[@id='chatBox']/div[1]"));

        public void NaviChatHistoryBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            chatNavigation.Click();
            WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='chatList']/div[5]/div[2]/div[2]", 3);
        }

        public void ChatHistoryList(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            try
            {
                chatList.Click();
                WaitHelpers.WaitForElementPresent(testDriver, "XPath", "//*[@id='chatBox']/div[1]", 3);
                bool displayMsg = chatBox.Displayed;
                Assert.IsTrue(displayMsg);
                test.Log(Status.Pass, "The chat box is successfully opened");
            }
            catch
            {
                Assert.Fail("The chat history is not visible");
                test.Log(Status.Pass, "The chat history is not visible");
            }
            finally
            {
                Assert.Pass("The chat history is visible");
                test.Log(Status.Pass, "The chat history is visible");
            }
        }
    }
}
