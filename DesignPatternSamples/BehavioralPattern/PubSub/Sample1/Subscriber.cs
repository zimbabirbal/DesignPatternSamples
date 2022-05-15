namespace DesignPattern.BehavioralPattern.PubSub.Sample1
{
    internal class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.myEvent += Publisher_myEvent;
        }

        public void UnSubscribe ( Publisher publisher)
        {
            publisher.myEvent -= Publisher_myEvent;
        }

        private void Publisher_myEvent(object? sender, EventArgument e)
        {
            var publisher = sender as Publisher;
            Console.WriteLine($"{publisher.Name} sent this message: {e.Message}");
        }
    }
}
