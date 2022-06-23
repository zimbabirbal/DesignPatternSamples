namespace DesignPatternSamples.CreationalPattern.Prototype.Sample1
{
    internal interface IEmployee
    {
        IEmployee Clone();
        string GetEmployeeDetails();
    }
}
