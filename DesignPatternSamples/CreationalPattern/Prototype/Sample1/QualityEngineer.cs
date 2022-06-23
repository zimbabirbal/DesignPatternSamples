namespace DesignPatternSamples.CreationalPattern.Prototype.Sample1
{
    internal class QualityEngineer : IEmployee
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public IEmployee Clone()
        {
            return (IEmployee) this.MemberwiseClone();
        }

        public string GetEmployeeDetails()
        {
            return $"This is a Quality Engineer info: {_name}";
        }
    }
}
