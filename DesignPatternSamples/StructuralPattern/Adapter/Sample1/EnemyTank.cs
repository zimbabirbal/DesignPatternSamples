namespace DesignPatternSamples.StructuralPattern.Adapter.Sample1
{
    internal class EnemyTank : IEnemyAttacker
    {
        public void AssignDriver(string driver)
        {
            Console.WriteLine($"This a {driver} driver.");
        }

        public void DriveForward()
        {
            Console.WriteLine($"This a moving forward.");
        }

        public void FireWeapon()
        {
            Console.WriteLine("This is firing a weapon.");
        }
    }
}
