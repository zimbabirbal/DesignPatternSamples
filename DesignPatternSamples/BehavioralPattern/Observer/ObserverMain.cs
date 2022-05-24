using DesignPatternSamples.BehavioralPattern.Observer.Sample1;
using DesignPatternSamples.BehavioralPattern.Observer.Sample2;

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
    /// Sample 2 contains microsoft built in Observer design pattern
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

            Console.WriteLine("\n-----------------Sample 2 using MS built in Observer pattern ------------------");
            BaggageHandler provider = new BaggageHandler();
            ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaim");
            ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityCheck");

            provider.BaggageStatus(1, "kathmandu", 2);
            observer1.Subscribe(provider);
            provider.BaggageStatus(2, "delhi", 3);
            provider.BaggageStatus(3, "bangalore", 5);
            provider.BaggageStatus(4, "goa", 6);
            observer2.Subscribe(provider);

            provider.BaggageStatus(5, "bangalore", 3);
            provider.BaggageStatus(6, "delhi", 2);
            provider.BaggageStatus(5);

            observer2.Unsubscribe();

            provider.BaggageStatus(4);
            provider.BaggageStatus(3);
            provider.BaggageStatus(2);
            provider.BaggageStatus(1);
            provider.LastBaggageClaimed();

            Console.ReadKey();

        }
    }
}
