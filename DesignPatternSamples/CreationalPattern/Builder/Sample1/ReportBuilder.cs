namespace DesignPatternSamples.CreationalPattern.Builder.Sample1
{
    internal abstract class ReportBuilder
    {
        private Report _report;

        protected Report ReportFromBuilder { get => _report; set => _report = value; }
        public abstract void AddName();
        public abstract void AddDescription();
        public abstract void AddType();
        public abstract void AddCreatedDate();

        public void CreateNewReport()
        {
            _report = new Report();
        }

        public Report GetReport()
        {
            return _report;
        }

    }
}
