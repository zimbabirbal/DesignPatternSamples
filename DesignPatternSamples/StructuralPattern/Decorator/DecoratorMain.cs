using DesignPatternSamples.StructuralPattern.Decorator.Sample1;

namespace DesignPatternSamples.StructuralPattern.Decorator
{
    /// <summary>
    /// Identifications:
    /// It is a structural pattern that allows adding new behaviors to objects dynamically by placing them 
    /// inside special wrapper objects
    /// Using decorators you can wrap objects countless number of times since both target objects and decorators follow the same interface. 
    /// The resulting object will get a stacking behavior of all wrappers.
    /// Decorator can be recognized by creation methods or constructor that accept objects of the same class or interface as a current class.
    /// 
    /// Usages:
    /// The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.
    /// The idea of the Decorator Pattern is to wrap an existing class, add other functionality to it, 
    /// then expose the same interface to the outside world.Because of this our decorator exactly looks like the original class to the 
    /// people who are using it.
    /// </summary>
    internal class DecoratorMain
    {
        public static void Main()
        {
            Console.WriteLine("--------------------Decorator Design Pattern Sample1---------------------------------");
            ICar carObj = new LuxuryCar();
            CarAccessoriesDecorator carAccessoriesDecorator = new BasicAccessories(carObj);
            carAccessoriesDecorator = new AdvancedAccessories(carAccessoriesDecorator);
            carAccessoriesDecorator = new SportAccessories(carAccessoriesDecorator);

            Console.WriteLine($"Car Details:{carAccessoriesDecorator.GetDescription()}");
            Console.WriteLine($"Car Name: {carAccessoriesDecorator.GetName()}");

        }
    }
}
