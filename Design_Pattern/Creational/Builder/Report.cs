
namespace Design_Pattern.Creational.Builder
{
    /*
        This is our product class, and within it, we define the attributes 
        (such as ReportHeader, ReportType, ReportFooter, and ReportContent) that are common to create a report. 
        We also define one method, i.e., DisplayReport, to display the report details in the console.
    */
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportFooter { get; set; }
        public string ReportContent { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("Report Type :" + ReportType);
            Console.WriteLine("Header :" + ReportHeader);
            Console.WriteLine("Content :" + ReportContent);
            Console.WriteLine("Footer :" + ReportFooter);
        }
    }
}
