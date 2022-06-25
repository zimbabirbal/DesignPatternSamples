namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2
{
    internal class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request as string == "banana")
                return $"I {this.GetType().Name} will eat it";
            else
                return base.Handle(request);
        }
    }
}
