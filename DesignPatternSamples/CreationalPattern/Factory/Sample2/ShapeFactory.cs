using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.CreationalPattern.Factory.Sample2
{
    internal class ShapeFactory
    {
        public IShape GetShapeInstance(ShapeType shapeType)
        {
            IShape shape;

            if (shapeType == ShapeType.Rectangle)
                shape = new Rectangle();
            else if (shapeType == ShapeType.Triangle)
                shape = new Triangle();
            else if (shapeType == ShapeType.Circle)
                shape = new Circle();
            else
            {
                shape = new Rectangle();
            }

            return shape;
        }
    }
}
