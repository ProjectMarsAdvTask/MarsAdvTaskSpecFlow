using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsAdvTaskSpecFlow.Utils
{
    public class CommonDriver
    {
        public static IWebDriver testDriver;

        public static void Initialize()
        {
            // open chrome browser
            testDriver = new ChromeDriver();

            // login page object initialization and definition
            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginAction(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            testDriver.Quit();
        }
    }
}
