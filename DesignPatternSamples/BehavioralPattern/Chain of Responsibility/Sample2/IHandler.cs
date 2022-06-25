namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}
