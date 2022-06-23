namespace DesignPatternSamples.CreationalPattern.Prototype.Sample1
{
    internal class Developer : IEmployee
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public IEmployee Clone()
        {
            //it's not deep copy only shallow copy
            return (IEmployee)this.MemberwiseClone();
        }

        public string GetEmployeeDetails()
        {
            return $"This is developer info: {_name}";
        }
    }
}
