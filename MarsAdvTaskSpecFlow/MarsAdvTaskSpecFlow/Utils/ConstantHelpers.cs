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
        //public static string ReportsPath = "@/MarsAdvTaskSpecFlow/TestReports/Reports";
        public static string ReportsPath = Directory.GetParent(@"@/MarsAdvTaskSpecFlow/TestReports/Reports").FullName
            + Path.DirectorySeparatorChar + "Report"
            + Path.DirectorySeparatorChar + "Report_" + DateTime.Now.ToString("ddMMyyyy HHmmss")
            + Path.DirectorySeparatorChar;

        //ReportXML Path
        public static string ReportXMLPath = "";
    }
}
