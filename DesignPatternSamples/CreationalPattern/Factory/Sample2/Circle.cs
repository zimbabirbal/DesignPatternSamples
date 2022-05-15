using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSamples.CreationalPattern.Factory.Sample2
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
}
