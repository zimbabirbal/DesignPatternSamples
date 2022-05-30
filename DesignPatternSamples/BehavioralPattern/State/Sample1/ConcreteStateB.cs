namespace DesignPatternSamples.BehavioralPattern.State.Sample1
{
    internal class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine($"Handle from ConcreateState B.");
            context.State = new ConcreteStateA();
        }
    }
}