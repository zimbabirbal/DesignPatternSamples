namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal class ReportGenerator
    {
        public Report Generate(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.AddName();
            reportBuilder.AddDescription();
            reportBuilder.AddCreatedDate();
            reportBuilder.AddType();

            return reportBuilder.GetReport();
        }
    }
}
