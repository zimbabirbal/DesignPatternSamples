using DesignPatternSamples.CreationalPattern.Prototype.Sample1;

namespace DesignPatternSamples.CreationalPattern.Prototype
{
    /// <summary>
    /// Identifications:
    /// The Prototype design pattern specifies the kind of objects to create using a prototypical instance, 
    /// and create new objects by copying this prototype.
    /// 
    /// Object.MemberwiseClone Method is used to create a shallow copy in .net or make clone of the current Object.
    /// Shallow copy is a bit-wise copy of an object. In this case, a new object is created and that object 
    /// has an exact copy of the existing object. Basically, this method copies the non-static fields of the 
    /// current object to the new object.
    /// If a field is a reference type, then the only reference is copied not the referred object.
    /// So here, the cloned object and the original object will refer to the same object.
    /// If the field is value type then the bit-by-bit copy of the field will be performed
    /// 
    /// Usages:
    /// Use this pattern when creation of object is very complex or costly.
    /// </summary>
    internal class PrototypeMain
    {
        public static void Main()
        {
            Console.WriteLine($"----------------Prototype Pattern Sample 1 ------------------");

            Console.WriteLine($"When trying to cloning object from referencing it");
            var rDev = new Developer();
            rDev.Name = "Wilson";
            Console.WriteLine($"This is orginal dev name: {rDev.Name} ");
            var rDev1 = rDev;
            Console.WriteLine($"This is clone dev name: {rDev1.Name} ");
            rDev1.Name = "WonderThwat";
            Console.WriteLine("Trying to change dev name of clone obj....");
            Console.WriteLine($"This is clone dev name: {rDev1.Name} ");
            Console.WriteLine($"This is orginal dev name: {rDev.Name} ");

            Console.WriteLine($"\nWhen trying to cloning object using the MemeberWiseClone");

            var developer = new Developer();
            developer.Name = "John";
            Console.WriteLine($"Orignal dev name {developer.Name}");
            var dev1 = (Developer) developer.Clone();
            Console.WriteLine($"Clone object dev name {dev1.Name}"); ;
            dev1.Name = "Syuam";
            Console.WriteLine($"Changing the clone dev...");
            Console.WriteLine($"Clone object dev name: {dev1.Name}");
            Console.WriteLine($"Orginal object dev name: {developer.Name}");
        }
    }
}
