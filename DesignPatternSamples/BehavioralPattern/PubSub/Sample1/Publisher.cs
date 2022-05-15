namespace DesignPattern.BehavioralPattern.PubSub.Sample1
{
    internal class Publisher
    {
        public string Name { get; set; }
        public event EventHandler<EventArgument> myEvent;

        public void Notify(string message)
        {
            EventArgument args = new EventArgument(message);

            if(myEvent != null)
                myEvent(this, args);
        }
    }
}
