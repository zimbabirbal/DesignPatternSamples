namespace DesignPatternSamples.StructuralPattern.Proxy.Sample1
{
    internal class NepaleseGovernmentOfficer : IGovernmentSite
    {
        public void GetGovDoc(string officerPost)
        {
            Console.WriteLine($"This is from {officerPost}, I can access it.");
        }
    }
}
