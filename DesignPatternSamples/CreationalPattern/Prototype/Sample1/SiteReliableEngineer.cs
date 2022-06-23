namespace DesignPatternSamples.CreationalPattern.Prototype.Sample1
{
    internal class SiteReliableEngineer : IEmployee
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public IEmployee Clone()
        {
            return (IEmployee) this.MemberwiseClone();
        }

        public string GetEmployeeDetails()
        {
            return $"This is from Site Reliable Engineer info: {_name}";
        }
    }
}
