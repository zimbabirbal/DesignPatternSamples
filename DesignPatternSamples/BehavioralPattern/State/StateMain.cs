using DesignPatternSamples.BehavioralPattern.State.Sample1;

namespace DesignPatternSamples.BehavioralPattern.State
{
    /// <summary>
    /// Identifications:
    /// It allow an object to alter its behavior when its internal state changes
    ///  
    /// Usage Examples:
    /// The State pattern is commonly used to convert massive switch-base state machines into the objects.
    /// </summary>
    internal class StateMain
    {
        public static void Main()
        {
            Console.WriteLine($"-----------------State pattern Sample 1 ----------------------");
            Context context = new Context(new ConcreteStateA());

            //set Concrete state to A.
            context.Request();

            //set Concrete state to B.
            context.Request();

            Console.ReadLine();
        }
    }
}
