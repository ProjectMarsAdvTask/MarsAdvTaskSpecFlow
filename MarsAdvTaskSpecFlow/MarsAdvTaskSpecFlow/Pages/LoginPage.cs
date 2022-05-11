using MarsAdvTaskSpecFlow.Utils;
using OpenQA.Selenium;
using System;

namespace MarsAdvTaskSpecFlow.Pages.ProfilePage
{
    class LoginPage
    {
        private IWebDriver testDriver;

        private IWebElement logIn => testDriver.FindElement(By.XPath("//a[normalize-space()='Sign In']"));
        private IWebElement emailAddressTxtBox => testDriver.FindElement(By.Name("email"));
        private IWebElement passwordTxtBox => testDriver.FindElement(By.Name("password"));
        private IWebElement logInBtn => testDriver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        private IWebElement profileName => testDriver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

        public void GoToHomePage(IWebDriver testDriver)
        {
            // Launch turn up portal and maximize window
            testDriver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            testDriver.Manage().Window.Maximize();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            testDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        public void ClickSignInBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Identify Sign In button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//a[normalize-space()='Sign In']", 2);       
            logIn.Click();
        }

        public void KeyInCredentials1(IWebDriver testDriver, string Email, string Password)
        {
            // Identify the email textbox enter valid email
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "email", 2);
            emailAddressTxtBox.SendKeys(Email);

            // Identify password textbox enter valid password
            WaitHelpers.WaitForElementPresent(testDriver, "Name", "password", 2);
            passwordTxtBox.SendKeys(Password);
        }

        public void ClickLoginBtn(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//button[normalize-space()='Login']", 2);
            logInBtn.Click();
        }

        public void LoginPageSteps(IWebDriver testDriver)
        {
            this.testDriver = testDriver;
            // Launch turn up portal and maximize window
            testDriver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            testDriver.Manage().Window.Maximize();
            testDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            testDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            // Identify Sign In button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//a[normalize-space()='Sign In']", 2);
            logInBtn.Click();

            // Identify the email textbox enter valid email
            //WaitHelpers.WaitForElementPresent(testDriver, "Name", "email", 2);
            IWebElement emailTextBox = testDriver.FindElement(By.Name("email"));
            string Email = "jlfuturistictech@hotmail.com";
            emailAddressTxtBox.SendKeys(Email);

            // Identify password textbox enter valid password
            //WaitHelpers.WaitForElementPresent(testDriver, "Name", "password", 2);
            IWebElement passwordTextBox = testDriver.FindElement(By.Name("password"));
            string Password = "JialeQA2021";
            passwordTxtBox.SendKeys(Password);

            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//button[normalize-space()='Login']", 2);
            logInBtn.Click();
        }
    }
}
