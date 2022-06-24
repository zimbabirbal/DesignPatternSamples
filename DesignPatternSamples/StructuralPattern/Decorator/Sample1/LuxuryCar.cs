namespace DesignPatternSamples.StructuralPattern.Decorator.Sample1
{
    internal class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "This is expensive Luxury Car";
        }

        public string GetName()
        {
            return "Z-eus x11 Car Model";
        }
    }
}
