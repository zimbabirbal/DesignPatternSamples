namespace DesignPatternSamples.StructuralPattern.Decorator.Sample1
{
    internal class BasicAccessories: CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " This is from Basic Accessories";
        }

        public override string GetName()
        {
            return base.GetName()+ " This is from Basic";
        }
    }
}
