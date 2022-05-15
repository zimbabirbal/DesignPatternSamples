namespace DesignPatternSamples.StructuralPattern.Bridge.Sample1
{
    internal class RedCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Red circle of r={radius}, x={x}, y={y}");
        }
    }
}
