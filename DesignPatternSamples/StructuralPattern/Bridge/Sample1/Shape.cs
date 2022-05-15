namespace DesignPatternSamples.StructuralPattern.Bridge.Sample1
{
    internal abstract class Shape
    {
        private IDrawAPI _drawAPI;
        protected IDrawAPI DrawAPI { get => _drawAPI; set => _drawAPI = value; }
        public Shape(IDrawAPI drawAPI)
        {
            _drawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
