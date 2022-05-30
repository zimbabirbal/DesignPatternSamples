namespace DesignPatternSamples.BehavioralPattern.State.Sample1
{
    internal class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine($"Handle from ConcreateState A.");
            context.State = new ConcreteStateB();
        }
    }
}
