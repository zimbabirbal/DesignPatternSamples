namespace DesignPatternSamples.StructuralPattern.Bridge.Sample2
{
    internal class ConcreteAImplementor : Implementor
    {
        public string Name { get; set; }
        public override void DoWork()
        {
            Console.WriteLine("This is from Concrete A Implementor.");
        }
    }
}
