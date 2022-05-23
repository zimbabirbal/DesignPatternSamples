using DesignPatternSamples.BehavioralPattern.Observer.Sample1;

namespace DesignPatternSamples.BehavioralPattern.Observer
{
    /// <summary>
    /// Identifications:
    /// Define a one-to-many dependency between objects so that when one object changes state, 
    /// all its dependents are notified and updated automatically
    /// an object (called as Subject) maintains a list of its dependents (called as Observers) and notifies them automatically 
    /// whenever any state changes by calling one of their methods.
    ///
    /// Usage Examples:
    /// Online shoping app, when item is out of stock and users subscribe to it and get notified
    /// when item is avaliable.
    /// </summary>
    internal class ObserverMain
    {
        public static void Main()
        {
            Console.WriteLine("------------------Observer pattern sample 1--------------------");

            Subject subject = new Subject("RTX-3060", 2000, "out of stock");
            IObserver mikeUser = new Sample1.Observer("Mike", subject);
            IObserver jonUser = new Sample1.Observer("Jon", subject);
            IObserver mariaUser = new Sample1.Observer("Maria", subject);

            Console.WriteLine($"RTX-360 is {subject.Avaliability} now");
            Console.WriteLine("Set the product avaliability and notify to customer.");

            subject.SetAvaliability("avaliable on stock");

            Console.WriteLine("Set product unavaliable");
            subject.UnregisterObserver(mariaUser); //assume maria purchase the item.

            subject.SetAvaliability("unavaliable");

            Console.ReadKey();

        }
    }
}
