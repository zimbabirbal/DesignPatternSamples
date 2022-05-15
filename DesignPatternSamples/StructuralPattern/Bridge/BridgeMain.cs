using DesignPatternSamples.StructuralPattern.Bridge.Sample1;

namespace DesignPatternSamples.StructuralPattern.Bridge
{
    /// <summary>
    /// Identification:
    /// Bridge is a structural design pattern that lets you split a large class or a set of closely 
    /// related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
    /// this pattern decouples implementation class and abstract class by 
    /// providing a bridge structure between them.
    /// 
    /// Usage Examples:
    /// Use the Bridge pattern when you want to divide and organize a monolithic class that 
    /// has several variants of some functionality.
    /// Use the pattern when you need to extend a class in several orthogonal (independent) dimensions.
    /// The Bridge suggests that you extract a separate class hierarchy for each of the dimensions. 
    /// The original class delegates the related work to the objects belonging to those hierarchies instead of doing everything on its own.
    /// </summary>
    internal class BridgeMain
    {
        public static void Main()
        {
            //Sample1
            Console.WriteLine("------------Bridge pattern Sample1---------------");
            Console.WriteLine("Drawing a color Circles");

            Shape redCircle = new Circle(10, 10, 5, new RedCircle());
            Shape blueCircle = new Circle(4, 4, 2, new BlueCircle());

            redCircle.Draw();
            blueCircle.Draw();

            Console.ReadKey();

        }
    }
}
