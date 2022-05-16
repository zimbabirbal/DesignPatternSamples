namespace DesignPatternSamples.StructuralPattern.Bridge.Sample2
{
    internal class ConcreteBImplementor : Implementor
    {
        public override void DoWork()
        {
            Console.WriteLine("This is from Concrete B Implementor.");
        }
    }
}
