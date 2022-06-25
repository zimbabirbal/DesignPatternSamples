namespace DesignPatternSamples.BehavioralPattern.Chain_of_Responsibility.Sample2
{
    internal class HumanHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request as string == "coffee")
                return $"I {this.GetType().Name} will eat this";

            return base.Handle(request);
        }
    }
}
