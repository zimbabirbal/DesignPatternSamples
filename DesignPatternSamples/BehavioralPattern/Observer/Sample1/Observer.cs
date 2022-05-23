namespace DesignPatternSamples.BehavioralPattern.Observer.Sample1
{
    internal class Observer : IObserver
    {
        public string Username { get; set; }
        public Observer(string username, ISubject subject)
        {
            Username = username;
            subject.RegisterObserver(this);
        }
        public void Update(string avaliability)
        {
            Console.WriteLine($"{Username} product is now {avaliability}.");
        }
    }
}
