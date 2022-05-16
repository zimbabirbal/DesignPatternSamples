namespace DesignPatternSamples.StructuralPattern.Adapter.Sample2
{
    internal class EmployeeManager
    {
        private List<Employee> _employees;

        public List<Employee> Employees { get => _employees; set => _employees = value; }
        public EmployeeManager()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee() { EmployeeID = 1, Name = "Jack" });
            _employees.Add(new Employee() { EmployeeID = 2, Name = "Mark" });
            _employees.Add(new Employee() { EmployeeID = 2, Name = "Birbal" });
        }

        public virtual string GetAllEmployees()
        {
            return string.Join(", ", _employees.Select(x => x.EmployeeID + ":" + x.Name));
        }
    }
}
