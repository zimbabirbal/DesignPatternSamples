namespace DesignPatternSamples.StructuralPattern.Bridge.Sample1
{
    internal class BlueCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Blue circle of r={radius}, x={x}, y={y}");
        }
    }
}
