using DesignPatternSamples.StructuralPattern.Adapter.Sample1;
using DesignPatternSamples.StructuralPattern.Adapter.Sample2;

namespace DesignPatternSamples.StructuralPattern.Adapter
{
    /// <summary>
    /// Identifications:
    /// The adapter design pattern allows incompatible classes to interact with each other by converting
    /// the interface of one class into interface expected by the clients.
    /// This design pattern involves a single class called adapter which is responsible for 
    /// communication between independent or incompatible interfaces
    /// 
    /// Usage Examples:
    /// These incompatible classes may come from different libraries or frameworks.
    /// Use the Adapter class when you want to use some existing class, but its interface isn’t compatible with the rest of your code
    /// Use the pattern when you want to reuse several existing subclasses that lack some common functionality that can’t be added to the base class
    /// </summary>
    internal class AdapterMain
    {
        public static void Main()
        {
            Console.WriteLine("---------------Adapter pattern Sample 1-----------------");
            Console.WriteLine("Testing for enemy Robot incompatible class");
            EnemyRobot enemyRobot = new EnemyRobot();
            IEnemyAttacker attacker = new EnemyRobotAdapter(enemyRobot);
            attacker.AssignDriver("Mark");
            attacker.DriveForward();
            attacker.FireWeapon();

            Console.WriteLine("\n---------------Adapter pattern Sample 2-----------------");
            Console.WriteLine("Testing for employee manager incompatible class");

            IEmployee employee = new EmployeeAdapter();
            var employeeList = employee.GetAllEmployees();
            Console.WriteLine($"All employess: {employeeList}");

            Console.ReadKey();

        }
    }
}
