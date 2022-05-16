namespace DesignPatternSamples.StructuralPattern.Bridge.Sample2
{
    internal class RefinedAbstraction: Abstraction
    {
        public override void DoOperation()
        {
            Implementor.DoWork();
        }
    }
}
