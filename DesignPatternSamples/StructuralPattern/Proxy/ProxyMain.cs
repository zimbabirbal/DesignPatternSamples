using DesignPatternSamples.StructuralPattern.Proxy.Sample1;

namespace DesignPatternSamples.StructuralPattern.Proxy
{
    /// <summary>
    /// Identifications:
    /// It provides a surrogate or placeholder for another object to control access to it.
    /// 
    /// Usage Examples:
    /// The proxy pattern can be used to restrict access to an object, to provide a simpler or lightweight interface, 
    /// or to allow the client to communicate with a remote object via a local representation.
    /// </summary>
    internal class ProxyMain
    {
        public static void Main()
        {
            Console.WriteLine("------------------Proxy pattern Sample1------------------------");
            IGovernmentSite governmentSite = new NepaleseForeignGovOfficer();
            governmentSite.GetGovDoc(nameof(governmentSite));

            Console.ReadKey();
        }
    }
}
