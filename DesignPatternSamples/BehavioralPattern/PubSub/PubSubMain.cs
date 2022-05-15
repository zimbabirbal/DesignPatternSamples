using DesignPattern.BehavioralPattern.PubSub.Sample1;

namespace DesignPattern.BehavioralPattern.PubSub
{
    /// <summary>
    /// Identifications:
    /// It is messaging pattern that provides a framework for exchanging messages that 
    /// allows for loose coupling and scaling between the sender of messages (publishers) and 
    /// receivers (subscribers) on topics they subscribe to.
    /// It allows loose coupling between the application components.
    /// Here publishers, do not program the messages to be sent directly to specific receivers, messages are 
    /// published without the knowledge of what or if any subscriber of that knowledge exists.
    /// 
    ///Usage Examples:
    ///Messages are sent from a publisher to subscribers as they become available. 
    ///The publisher publishes messages (events) to channels (topics). 
    ///Subscribers can subscribe to the topics they are interested in.
    /// </summary>
    internal class PubSubMain
    {
        public static void Main()
        {
            //Sample1
            Console.WriteLine("-------------PubSub Sample1-----------------");

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
