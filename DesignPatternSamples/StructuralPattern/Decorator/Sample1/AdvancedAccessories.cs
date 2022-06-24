namespace DesignPatternSamples.StructuralPattern.Decorator.Sample1
{
    internal class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " This is from AdvancedAccessories.";
        }

        public override string GetName()
        {
            return base.GetName() + " This is a Advanced.";
        }
    }
}
