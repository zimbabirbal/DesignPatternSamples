namespace DesignPattern.BehavioralPattern.Strategy.Sample2
{
    internal class Employee
    {
        public string Name { get => _name; set => _name = value; }
        private string _name;
        private IRole _role;

        public Employee(string name, IRole role)
        {
            _name = name;
            _role = role;
        }

        public void Promote(IRole newRole)
        {
            _role = newRole;
        }

        public string Description()
        {
            return $"{_role.Description()}";
        }

        public string MyWork()
        {
            return $"{_role.Responsibilites()}";
        }
    }

}
