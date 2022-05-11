using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using TechTalk.SpecFlow;
using static MarsAdvTaskSpecFlow.Utils.CommonMethods;

namespace MarsAdvTaskSpecFlow.Utils
{
    [Binding]
    class Hooks : Steps
    {
        //private IWebDriver testDriver;

        // ExtentReports
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        [BeforeTestRun]
        public static void InitializeReport()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(ConstantHelpers.ReportsPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterStep]
        public static void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                scenario.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                scenario.Log(Status.Fail, context.StepContext.StepInfo.Text);
            }
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featurecontext)
        {
            featureName = extent.CreateTest(featurecontext.FeatureInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }

        [BeforeScenario]
        [Obsolete]
        public static void Setup()
        {
            // CommonDriver.Initialize();
            // Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]
        //[AfterTestRun]
        public static void CloseTestRun(ScenarioContext context)
        {
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(CommonDriver.testDriver, context.ScenarioInfo.Title);
            featureName.Log(Status.Info, "Snapshot below: " + featureName.AddScreenCaptureFromPath(img));
        }
    }
}
