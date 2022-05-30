namespace DesignPatternSamples.StructuralPattern.Proxy.Sample1
{
    internal class NepaleseForeignGovOfficer : IGovernmentSite
    {
        private NepaleseGovernmentOfficer _nepaleseGovernmentOfficer;
        public void GetGovDoc(string officerType)
        {
            if(_nepaleseGovernmentOfficer == null)
                _nepaleseGovernmentOfficer = new NepaleseGovernmentOfficer();

            _nepaleseGovernmentOfficer.GetGovDoc(officerType);
        }
    }
}
