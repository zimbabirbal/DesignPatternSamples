namespace DesignPatternSamples.StructuralPattern.Adapter.Sample2
{
    internal class EmployeeAdapter: EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
            Employees.Add(new Employee() { EmployeeID = 44, Name = "Shelly" });
            return base.GetAllEmployees();
        }
    }
}
