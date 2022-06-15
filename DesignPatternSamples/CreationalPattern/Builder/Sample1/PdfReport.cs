namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal class PdfReport : ReportBuilder
    {
        public override void AddCreatedDate()
        {
            ReportFromBuilder.Created = DateTime.UtcNow;
        }

        public override void AddDescription()
        {
            ReportFromBuilder.Description = "This is pdf document";
        }

        public override void AddName()
        {
            ReportFromBuilder.Name = "PdfDocument";
        }

        public override void AddType()
        {
            ReportFromBuilder.Type = ".pdf";
        }
    }
}
