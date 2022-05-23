namespace DesignPatternSamples.BehavioralPattern.Observer.Sample1
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers();
    }
}
