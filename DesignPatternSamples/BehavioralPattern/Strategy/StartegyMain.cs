using DesignPattern.BehavioralPattern.Strategy.Sample1;
using DesignPattern.BehavioralPattern.Strategy.Sample2;

namespace DesignPattern.BehavioralPattern.Strategy
{
    /// <summary>
    /// Usage examples: 
    /// The Strategy pattern is very common in C# code. It’s often used in various frameworks to provide users a way to 
    /// change the behavior of a class without extending it.
    /// Identification: 
    /// Strategy pattern can be recognized by a method that lets nested object do the actual work, 
    /// as well as the setter that allows replacing that object with a different one.
    /// </summary>
    public class StartegyMain
    {
        public static void Main()
        {
            //Sample1
            Console.WriteLine("------------Strategy Sample1----------------");
            var context = new Context();
            Console.WriteLine("client: ConcreteStrategyA is set to normal sorting");

            context.SetStrategyContext(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine("client: ConcreteStrategyB is set to reverse sorting");
            context.SetStrategyContext(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            //Sample2
            Console.WriteLine("-------------------Starting Sample 2 ---------------------");

            Employee employee1 = new Employee("Ram", new Consultant());
            Employee employee2 = new Employee("Shayam", new SeniorConsultant());

            Console.WriteLine($"{employee1.Name}: Position: {employee1.Description()}");
            Console.WriteLine($"Job: {employee1.MyWork()}");
            Console.WriteLine($"{employee2.Name}: Position: {employee2.Description()}");
            Console.WriteLine($"Job: {employee2.MyWork()}");

            Console.WriteLine("----------------Promoting the Employee----------------");

            employee1.Promote(new SeniorConsultant());
            employee2.Promote(new PrincilpleConsultant());

            Console.WriteLine($"{employee1.Name}: New Position: {employee1.Description()}");
            Console.WriteLine($"Job: {employee1.MyWork()}");
            Console.WriteLine($"{employee2.Name}: New Position: {employee2.Description()}");
            Console.WriteLine($"Job: {employee2.MyWork()}");

            Console.ReadKey();
        }
    }
}
