using System;
using System.IO;

namespace MarsAdvTaskSpecFlow.Utils
{
    class ConstantHelpers
    {
        //Base Url
        public static string BaseUrl = "http://localhost:5000/";

        //ScreenshotPath
        public static string ScreenshotPath = "@/MarsAdvTaskSpecFlow/TestReports/Screenshots/";

        //ExtentReportsPath
        //public static string ReportsPath = "@/MarsOnBoardingTask/TestReports/Reports";
        public static string ReportsPath = Directory.GetParent(@"@/MarsAdvTaskSpecFlow/TestReports/Reports").FullName
            + Path.DirectorySeparatorChar + "Screenshot"
            + Path.DirectorySeparatorChar + "Screenshot_" + DateTime.Now.ToString("ddMMyyyy HHmmss")
            + Path.DirectorySeparatorChar;

        //ReportXML Path
        public static string ReportXMLPath = "";
    }
}
