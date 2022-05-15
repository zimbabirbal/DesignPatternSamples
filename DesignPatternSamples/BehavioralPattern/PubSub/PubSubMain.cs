using DesignPattern.BehavioralPattern.PubSub.Sample1;

namespace DesignPattern.BehavioralPattern.PubSub
{
    internal class PubSubMain
    {
        public static void Main()
        {
            //Sample1
            Console.WriteLine("------------------Sample1-----------------");

            Publisher publisher = new Publisher();
            publisher.Name = "Publisher1";

            Subscriber subscriber = new Subscriber();
            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();

            subscriber.Subscribe(publisher);
            subscriber1.Subscribe(publisher);
            subscriber2.Subscribe(publisher);

            publisher.Notify("This is a first message must received by 3 subscribers.");

            subscriber.UnSubscribe(publisher);

            publisher.Notify("This is a second message must received by 2 subscribers.");

            Console.ReadKey();
        }
    }
}
