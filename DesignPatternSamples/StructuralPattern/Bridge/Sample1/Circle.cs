namespace DesignPatternSamples.StructuralPattern.Bridge.Sample1
{
    internal class Circle : Shape
    {
        int _x, _y, _radius;
        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }
        public override void Draw()
        {
            DrawAPI.DrawCircle(_radius, _x, _y);
        }
    }
}
