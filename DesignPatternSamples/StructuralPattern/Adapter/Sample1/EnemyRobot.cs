namespace DesignPatternSamples.StructuralPattern.Adapter.Sample1
{
    internal class EnemyRobot 
    {
        public void HumanController(string driver)
        {
            Console.WriteLine($"This is robot driving by {driver}");
        }

        public void WalkForward()
        {
            Console.WriteLine("This is a robot moving forward");
        }

        public void SmashWithHands()
        {
            Console.WriteLine("This is robot smashing the chair.");
        }
    }
}
