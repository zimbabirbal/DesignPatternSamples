using DesignPatternSamples.CreationalPattern.Factory.Sample1;
using DesignPatternSamples.CreationalPattern.Factory.Sample2;

namespace DesignPatternSamples.CreationalPattern.Factory
{
    /// <summary>
    /// Identification:
    /// Create an object without exposing the creation logic to the client and 
    /// refer to newly created object using a common interface.
    /// Use the Factory pattern when you don’t know beforehand the exact types and 
    /// dependencies of the objects your code should work with.
    /// 
    /// Usage Examples:
    /// To add a new product type to the app, you’ll only need to create a new creator subclass and 
    /// override the factory method in it.
    /// </summary>
    internal class FactoryMain
    {
        public static void Main()
        {
            //Sample1
            Console.WriteLine("------------Factory pattern Sample1---------------");
            Console.WriteLine("Testing for Android OS");
            MobileOSFactory mobileOSFactory = new MobileOSFactory();
            IMobileOS mobileOS = mobileOSFactory.GetMobileOSInstance("Android");
            Console.WriteLine($"Mobile OS: {mobileOS.Description()}");

            Console.WriteLine("Testing for iOS");
            mobileOS = mobileOSFactory.GetMobileOSInstance("iOS");
            Console.WriteLine($"Mobile OS: {mobileOS.Description()}");

            //Sample2
            Console.WriteLine("-----------Factory pattern Sample2------------------");
            Console.WriteLine("Testing for Circle shape");

            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape = shapeFactory.GetShapeInstance(ShapeType.Circle);
            shape.Draw();

            Console.WriteLine("Testing for Triangle shape");
            shape = shapeFactory.GetShapeInstance(ShapeType.Triangle);
            shape.Draw();

            Console.ReadKey();
        }
    }
}
