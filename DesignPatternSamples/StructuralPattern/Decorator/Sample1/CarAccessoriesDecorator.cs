namespace DesignPatternSamples.StructuralPattern.Decorator.Sample1
{
    internal class CarAccessoriesDecorator : ICar
    {
        private readonly ICar _car;
        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }
        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual string GetName()
        {
            return _car.GetName();
        }
    }
}
