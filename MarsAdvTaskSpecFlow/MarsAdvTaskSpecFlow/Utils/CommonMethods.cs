using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Text;

namespace MarsAdvTaskSpecFlow.Utils
{
    class CommonMethods
    {
        //Screenshots
        //Screenshot
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                // By capturing the ScreenShot
                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                // To create the file path
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }
    }
}
