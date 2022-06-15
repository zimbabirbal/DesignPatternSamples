using DesignPatternSamples.CreationalPattern.Builder.Sample1;

namespace DesignPatternSamples.CreationalPattern.Builder
{
    /// <summary>
    /// Identifications:
    /// Process of constructing a complex object should be generic so that the same construction process can be used to create 
    /// different representations of the same complex object.
    /// 
    /// Usage Examples:
    /// It is all about separating the construction process from its representation
    /// </summary>
    internal class BuilderMain
    {
        public static void Main()
        {
            Console.WriteLine("-------------Builder Design Pattern Sample 1 ---------------");
            var reportManager = new ReportManager();
            reportManager.CreateAllTypesOfReport();

            Console.ReadLine();
        }
    }
}
