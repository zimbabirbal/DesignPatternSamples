namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal class ExcelReport : ReportBuilder
    {
        public override void AddCreatedDate()
        {
            ReportFromBuilder.Created = DateTime.UtcNow;
        }

        public override void AddDescription()
        {
            ReportFromBuilder.Description = "This is Excel document";
        }

        public override void AddName()
        {
            ReportFromBuilder.Name = "Excel Docs";
        }

        public override void AddType()
        {
            ReportFromBuilder.Type = ".excel";
        }
    }
}
