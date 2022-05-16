namespace DesignPatternSamples.StructuralPattern.Bridge.Sample2
{
    internal class Abstraction
    {
        private Implementor _implementor;

        public Implementor Implementor { get => _implementor; set => _implementor = value; }

        public virtual void DoOperation()
        {
            _implementor.DoWork();
        }
    }
}
