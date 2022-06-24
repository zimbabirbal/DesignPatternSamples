namespace DesignPatternSamples.StructuralPattern.Decorator.Sample1
{
    internal class SportAccessories : CarAccessoriesDecorator
    {
        public SportAccessories(ICar car) : base(car)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " This is from Sport Accessories.";
        }
        public override string GetName()
        {
            return base.GetName()+ " This is a Sport";
        }
    }
}
