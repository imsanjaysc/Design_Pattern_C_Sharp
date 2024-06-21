
namespace Design_Pattern.Creational.Builder
{
    // The Director is only responsible for executing the building steps in a particular order. 
    // It is helpful when producing products according to a specific order or configuration. 
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}

/*
 Progarm.cs File
-----------------
using Design_Pattern.Creational.Builder;

// Constructing the PDF Report
// Step1: Create a Builder Object 
// Creating PDFReport Builder Object

PDFReport pdfReport = new PDFReport();
// Step2: Pass the Builder Object to the Director
// First Create an instance of ReportDirector
ReportDirector reportDirector = new ReportDirector();
// Then Pass the pdfReport Builder Object to the MakeReport Method of ReportDirector
// The ReportDirector will return one of the Representations of the Product
Report report = reportDirector.MakeReport(pdfReport);
// Step3: Display the Report by calling the DisplayReport method of the Product
report.DisplayReport();
Console.WriteLine("-------------------");
// Constructing the Excel Report
// The Process is going to be the same
ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();
Console.ReadKey();
 
 */
