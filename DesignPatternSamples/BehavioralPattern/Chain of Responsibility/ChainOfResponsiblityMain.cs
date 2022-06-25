using DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample1;
using DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2;

namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility
{
    /// <summary>
    /// Identifications:
    /// The Chain of Responsibility design pattern avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
    /// This pattern chains the receiving objects and passes the request along the chain until an object handles it.
    /// the Chain of Responsibility pattern in which several linked objects (the Chain) are offered the opportunity to 
    /// respond to a request or hand it off to the object next in line.
    /// 
    /// Usages:
    /// This real-world code demonstrates the Chain of Responsibility pattern in which several linked managers and 
    /// executives can respond to a purchase request or hand it off to a superior. 
    /// Each position has can have its own set of rules which orders they can approve.
    /// </summary>
    internal class ChainOfResponsiblityMain
    {
        public static void Main()
        {
            Console.WriteLine($"-------------Chain of Responsibility Sample 1 -----------------");

            Approver approver = new Director();
            Approver approver1 = new VicePresident();
            Approver approver2 = new President();

            //set the successor
            approver.SetSuccessor(approver1);
            approver1.SetSuccessor(approver2);

            var purchase = new Purchase()
            {
                Amount = 75000,
                Description = "Buy the Electric Generator",
                Purpose = "To use as a backup purpose"
            };

            approver.ProcessRequest(purchase);

            var purchase1 = new Purchase()
            {
                Amount = 35000,
                Description = "Buy the Furniture",
                Purpose = "For new Employees"
            };

            approver.ProcessRequest(purchase1);

            var purchase2 = new Purchase()
            {
                Amount = 9000,
                Description = "Beer and alchol",
                Purpose = "For upcomming new year party"
            };

            approver.ProcessRequest(purchase2);

            //sample 2
            Console.WriteLine($"\n-------------Chain of Responsibility Sample 2 -----------------");
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var human = new HumanHandler();

            monkey.SetNext(squirrel).SetNext(human);

            Console.WriteLine($"\nChain is Monkey, Squirrel, Man");

            var client = new ClientHandler();
            client.PassToClient(monkey);

            Console.WriteLine($"\nChain is Squirrel, Fish");
            client.PassToClient(squirrel);

            Console.WriteLine($"\nChain is Human, Fish");
            client.PassToClient(human);
        }
    }
}
