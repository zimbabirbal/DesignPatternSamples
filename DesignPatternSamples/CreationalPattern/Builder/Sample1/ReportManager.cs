namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal class ReportManager
    {
        public void CreateAllTypesOfReport()
        {
            var excelReport = new ExcelReport();
            var pdfReport = new PdfReport();

            var reportGenerator = new ReportGenerator();
            var report1 = reportGenerator.Generate(excelReport);
            Console.WriteLine($"Excel Report: {report1.Print()}");

            var report2 = reportGenerator.Generate(pdfReport);
            Console.WriteLine($"Excel Report: {report2.Print()}");
        }
    }
}
